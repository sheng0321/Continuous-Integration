using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;
using ConestogaVirtualGameStore.Server.Controllers;
using ConestogaVirtualGameStore.Server.Data;
using ConestogaVirtualGameStore.Server.Data.Models;
using System.ComponentModel.DataAnnotations;

public class OrderDetailsControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly OrderDetailsController _controller;

    public OrderDetailsControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new OrderDetailsController(_context);
    }

    [Fact]
    public async Task GetOrderDetails_ReturnsAllOrderDetails()
    {
        // Clear the OrderDetails table to ensure a clean state
        _context.OrderDetails.RemoveRange(_context.OrderDetails);
        await _context.SaveChangesAsync();
        // Arrange
        var orderDetails = new List<OrderDetail>
        {
            new OrderDetail { OrderDetailID = Guid.NewGuid(), OrderID = Guid.NewGuid(), GameID = Guid.NewGuid(), Quantity = 1, Price = 59.99m },
            new OrderDetail { OrderDetailID = Guid.NewGuid(), OrderID = Guid.NewGuid(), GameID = Guid.NewGuid(), Quantity = 2, Price = 39.99m }
        };

        _context.OrderDetails.AddRange(orderDetails);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetOrderDetails();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<OrderDetail>>>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<OrderDetail>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count());
    }

    [Fact]
    public async Task GetOrderDetail_ReturnsNotFound_WhenOrderDetailDoesNotExist()
    {
        // Clear the OrderDetails table to ensure a clean state
        _context.OrderDetails.RemoveRange(_context.OrderDetails);
        await _context.SaveChangesAsync();
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.GetOrderDetail(id);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
  
    public async Task GetOrderDetail_ReturnsOrderDetail_WhenExists()
    {
        // Clear the OrderDetails table to ensure a clean state
        _context.OrderDetails.RemoveRange(_context.OrderDetails);
        await _context.SaveChangesAsync();

        // Arrange
        var orderId = Guid.NewGuid();
        var gameId = Guid.NewGuid();
        var orderDetail = new OrderDetail
        {
            OrderDetailID = Guid.NewGuid(),
            OrderID = orderId,
            GameID = gameId,
            Quantity = 1,
            Price = 59.99m
        };
        _context.OrderDetails.Add(orderDetail);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetOrderDetail(orderDetail.OrderDetailID); // Use the correct ID

        // Assert
        var actionResult = Assert.IsType<ActionResult<OrderDetail>>(result);
        var returnValue = Assert.IsType<OrderDetail>(actionResult.Value);
        Assert.Equal(orderDetail.OrderDetailID, returnValue.OrderDetailID);
    }


    [Fact]
    public async Task PostOrderDetail_CreatesOrderDetail_WhenValid()
    {
        // Arrange
        var orderDetail = new OrderDetail
        {
            OrderDetailID = Guid.NewGuid(),
            OrderID = Guid.NewGuid(),
            GameID = Guid.NewGuid(),
            Quantity = 1,
            Price = 59.99m
        };

        // Act
        var result = await _controller.PostOrderDetail(orderDetail);

        // Assert
        var actionResult = Assert.IsType<ActionResult<OrderDetail>>(result);
        var createdResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
        Assert.Equal(orderDetail.OrderDetailID, ((OrderDetail)createdResult.Value).OrderDetailID);
    }

    [Fact]
 
    public async Task PostOrderDetail_ReturnsBadRequest_WhenQuantityIsInvalid()
    {
        // Arrange
        var orderDetail = new OrderDetail
        {
            OrderDetailID = Guid.NewGuid(),
            OrderID = Guid.NewGuid(),
            GameID = Guid.NewGuid(),
            Quantity = 0, // Invalid quantity
            Price = 59.99m
        };

        // Manually add validation errors to ModelState
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(orderDetail);
        bool isValid = Validator.TryValidateObject(orderDetail, validationContext, validationResults, true);

        if (!isValid)
        {
            foreach (var validationResult in validationResults)
            {
                _controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }
        }

        // Act
        var result = await _controller.PostOrderDetail(orderDetail);

        // Assert
        var actionResult = Assert.IsType<ActionResult<OrderDetail>>(result);
        Assert.IsType<BadRequestObjectResult>(actionResult.Result);
    }

    [Fact]
    public async Task PutOrderDetail_ReturnsNoContent_WhenUpdateIsSuccessful()
    {
        // Arrange
        var id = Guid.NewGuid();
        var orderDetail = new OrderDetail { OrderDetailID = id, OrderID = Guid.NewGuid(), GameID = Guid.NewGuid(), Quantity = 1, Price = 59.99m };
        _context.OrderDetails.Add(orderDetail);
        await _context.SaveChangesAsync();

        // Update the order detail
        orderDetail.Quantity = 2;

        // Act
        var result = await _controller.PutOrderDetail(id, orderDetail);

        // Assert
        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteOrderDetail_ReturnsNotFound_WhenOrderDetailDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.DeleteOrderDetail(id);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public async Task DeleteOrderDetail_ReturnsNoContent_WhenDeleted()
    {
        // Clear the OrderDetails table to ensure a clean state
        _context.OrderDetails.RemoveRange(_context.OrderDetails);
        await _context.SaveChangesAsync();

        // Arrange
        var id = Guid.NewGuid();
        var orderDetail = new OrderDetail { OrderDetailID = id, OrderID = Guid.NewGuid(), GameID = Guid.NewGuid(), Quantity = 1, Price = 59.99m };
        _context.OrderDetails.Add(orderDetail);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.DeleteOrderDetail(id);

        // Assert
        Assert.IsType<NoContentResult>(result);
        Assert.Null(await _context.OrderDetails.FindAsync(id));
    }
}
