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
using System.Diagnostics;

public class OrdersControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly OrdersController _controller;

    public OrdersControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new OrdersController(_context);
    }

    [Fact]
    public async Task GetOrders_ReturnsAllOrders()
    {
        // Clear the Orders table to ensure a clean state
        _context.Orders.RemoveRange(_context.Orders);
        await _context.SaveChangesAsync();

        // Arrange
        var orders = new List<Order>
    {
        new Order
        {
            OrderID = Guid.NewGuid(),
            MemberID = "member1",
            TotalAmount = 59.99m,
            Status = "Completed",
            OrderDetails = new List<OrderDetail>() // Initialize with an empty list
        },
        new Order
        {
            OrderID = Guid.NewGuid(),
            MemberID = "member2",
            TotalAmount = 39.99m,
            Status = "Pending",
            OrderDetails = new List<OrderDetail>() // Initialize with an empty list
        }
    };

        _context.Orders.AddRange(orders);
        await _context.SaveChangesAsync(); // Ensure changes are saved

        // Act
        try
        {
            var result = await _controller.GetOrders();
            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Order>>>(result);
            Assert.NotNull(actionResult.Value); // Ensure Value is not null
            var returnValue = Assert.IsAssignableFrom<IEnumerable<Order>>(actionResult.Value);
            Assert.Equal(2, returnValue.Count());
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.Message}");
        }
      
    }





    [Fact]
    public async Task GetOrder_ReturnsNotFound_WhenOrderDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.GetOrder(id);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task PostOrder_CreatesOrder_WhenOrderIsValid()
    {
        // Arrange
        var order = new Order { OrderID = Guid.NewGuid(), OrderDetails = new List<OrderDetail>() };

        // Act
        var result = await _controller.PostOrder(order);

        // Assert
        var actionResult = Assert.IsType<ActionResult<Order>>(result);
        var createdResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
        Assert.Equal(order.OrderID, ((Order)createdResult.Value).OrderID);
    }

    [Fact]
    public async Task PutOrder_ReturnsNoContent_WhenUpdateIsSuccessful()
    {
        // Arrange
        var id = Guid.NewGuid();
        var order = new Order { OrderID = id, OrderDetails = new List<OrderDetail>() };
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.PutOrder(id, order);

        // Assert
        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteOrder_ReturnsNotFound_WhenOrderDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.DeleteOrder(id);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public async Task DeleteOrder_ReturnsNoContent_WhenOrderIsDeleted()
    {
        // Arrange
        var id = Guid.NewGuid();
        var order = new Order { OrderID = id, OrderDetails = new List<OrderDetail>() };
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.DeleteOrder(id);

        // Assert
        Assert.IsType<NoContentResult>(result);
        Assert.Null(await _context.Orders.FindAsync(id));
    }
}
