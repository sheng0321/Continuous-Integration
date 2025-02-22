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

public class GameReviewsControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly GameReviewsController _controller;

    public GameReviewsControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new GameReviewsController(_context);
    }

    [Fact]
    public async Task GetGameReviews_ReturnsAllGameReviews()
    {
        // Clear the GameReviews table to ensure a clean state
        _context.GameReviews.RemoveRange(_context.GameReviews);
        await _context.SaveChangesAsync();
        // Arrange
        var gameReviews = new List<GameReview>
        {
            new GameReview { ReviewID = Guid.NewGuid(), MemberID = "member1", GameID = Guid.NewGuid(), ReviewText = "Great game!" },
            new GameReview { ReviewID = Guid.NewGuid(), MemberID = "member2", GameID = Guid.NewGuid(), ReviewText = "Not bad." }
        };

        _context.GameReviews.AddRange(gameReviews);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetGameReviews();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<GameReview>>>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<GameReview>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count());
    }

    [Fact]
    public async Task GetGameReview_ReturnsNotFound_WhenGameReviewDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.GetGameReview(id);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task GetGameReview_ReturnsGameReview_WhenExists()
    {
        // Arrange
        var id = Guid.NewGuid();
        var gameReview = new GameReview { ReviewID = id, MemberID = "member1", GameID = Guid.NewGuid(), ReviewText = "Great game!" };
        _context.GameReviews.Add(gameReview);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetGameReview(id);

        // Assert
        var actionResult = Assert.IsType<ActionResult<GameReview>>(result);
        var returnValue = Assert.IsType<GameReview>(actionResult.Value);
        Assert.Equal(id, returnValue.ReviewID);
    }

    [Fact]
    public async Task PostGameReview_CreatesGameReview_WhenValid()
    {
        // Arrange
        var gameReview = new GameReview
        {
            ReviewID = Guid.NewGuid(),
            MemberID = "member1",
            GameID = Guid.NewGuid(),
            ReviewText = "Awesome game!"
        };

        // Act
        var result = await _controller.PostGameReview(gameReview);

        // Assert
        var actionResult = Assert.IsType<ActionResult<GameReview>>(result);
        var createdResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
        Assert.Equal(gameReview.ReviewID, ((GameReview)createdResult.Value).ReviewID);
    }

    [Fact]
    public async Task PostGameReview_ReturnsBadRequest_WhenReviewAlreadyExists()
    {
        // Arrange
        var gameID = Guid.NewGuid();
        var gameReview = new GameReview
        {
            ReviewID = Guid.NewGuid(),
            MemberID = "member1",
            GameID = gameID,
            ReviewText = "Great game!"
        };

        _context.GameReviews.Add(gameReview);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.PostGameReview(gameReview);

        // Assert
        var actionResult = Assert.IsType<ActionResult<GameReview>>(result);
        Assert.IsType<BadRequestObjectResult>(actionResult.Result);
    }

    [Fact]
    public async Task PutGameReview_ReturnsNoContent_WhenUpdateIsSuccessful()
    {
        // Arrange
        var id = Guid.NewGuid();
        var gameReview = new GameReview { ReviewID = id, MemberID = "member1", GameID = Guid.NewGuid(), ReviewText = "Great game!" };
        _context.GameReviews.Add(gameReview);
        await _context.SaveChangesAsync();

        // Update the review
        gameReview.ReviewText = "Updated review text.";

        // Act
        var result = await _controller.PutGameReview(id, gameReview);

        // Assert
        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteGameReview_ReturnsNotFound_WhenGameReviewDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.DeleteGameReview(id);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public async Task DeleteGameReview_ReturnsNoContent_WhenDeleted()
    {
        // Arrange
        var id = Guid.NewGuid();
        var gameReview = new GameReview { ReviewID = id, MemberID = "member1", GameID = Guid.NewGuid(), ReviewText = "Great game!" };
        _context.GameReviews.Add(gameReview);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.DeleteGameReview(id);

        // Assert
        Assert.IsType<NoContentResult>(result);
        Assert.Null(await _context.GameReviews.FindAsync(id));
    }
}
