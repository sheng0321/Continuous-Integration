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

public class WishListsControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly WishListsController _controller;

    public WishListsControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new WishListsController(_context);
    }

    [Fact]
    public async Task GetWishLists_ReturnsAllWishLists()
    {
        // Clear the WishLists table to ensure a clean state
        _context.WishLists.RemoveRange(_context.WishLists);
        await _context.SaveChangesAsync();
        // Arrange
        var wishLists = new List<WishList>
        {
            new WishList { WishListID = Guid.NewGuid(), MemberID = "member1", GameID = Guid.NewGuid() },
            new WishList { WishListID = Guid.NewGuid(), MemberID = "member2", GameID = Guid.NewGuid() }
        };

        _context.WishLists.AddRange(wishLists);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetWishLists();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<WishList>>>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<WishList>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count());
    }

    [Fact]
    public async Task GetWishList_ReturnsNotFound_WhenWishListDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.GetWishList(id);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task PostWishList_ReturnsBadRequest_WhenProductAlreadyInWishlist()
    {
        // Arrange
        var wishList = new WishList { WishListID = Guid.NewGuid(), MemberID = "member1", GameID = Guid.NewGuid() };
        _context.WishLists.Add(wishList);
        await _context.SaveChangesAsync();

        var newWishList = new WishList { WishListID = Guid.NewGuid(), MemberID = "member1", GameID = wishList.GameID };

        // Act
        var result = await _controller.PostWishList(newWishList);

        // Assert
        var actionResult = Assert.IsType<ActionResult<WishList>>(result);
        Assert.IsType<BadRequestObjectResult>(actionResult.Result);
    }

    [Fact]
    public async Task PutWishList_ReturnsNoContent_WhenUpdateIsSuccessful()
    {
        // Arrange
        var id = Guid.NewGuid();
        var wishList = new WishList { WishListID = id, MemberID = "member1", GameID = Guid.NewGuid() };
        _context.WishLists.Add(wishList);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.PutWishList(id, wishList);

        // Assert
        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteWishList_ReturnsNotFound_WhenWishListDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.DeleteWishList(id);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public async Task DeleteWishList_ReturnsNoContent_WhenWishListIsDeleted()
    {
        // Arrange
        var id = Guid.NewGuid();
        var wishList = new WishList { WishListID = id, MemberID = "member1", GameID = Guid.NewGuid() };
        _context.WishLists.Add(wishList);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.DeleteWishList(id);

        // Assert
        Assert.IsType<NoContentResult>(result);
        Assert.Null(await _context.WishLists.FindAsync(id));
    }
}
