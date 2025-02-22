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

public class GameCategoriesControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly GameCategoriesController _controller;

    public GameCategoriesControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new GameCategoriesController(_context);
    }

    [Fact]
    public async Task GetGameCategories_ReturnsAllGameCategories()
    {
        // Clear the Language table to ensure a clean state
        _context.GameCategories.RemoveRange(_context.GameCategories);
        await _context.SaveChangesAsync();
        // Arrange
        var gameCategories = new List<GameCategory>
        {
            new GameCategory { Id = Guid.NewGuid(), Name = "Action" },
            new GameCategory { Id = Guid.NewGuid(), Name = "Adventure" }
        };

        _context.GameCategories.AddRange(gameCategories);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetGameCategories();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<GameCategory>>>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<GameCategory>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count());
    }

    [Fact]
    public async Task GetGameCategory_ReturnsNotFound_WhenGameCategoryDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.GetGameCategory(id);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task GetGameCategory_ReturnsGameCategory_WhenExists()
    {
        // Arrange
        var id = Guid.NewGuid();
        var gameCategory = new GameCategory { Id = id, Name = "RPG" };
        _context.GameCategories.Add(gameCategory);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetGameCategory(id);

        // Assert
        var actionResult = Assert.IsType<ActionResult<GameCategory>>(result);
        var returnValue = Assert.IsType<GameCategory>(actionResult.Value);
        Assert.Equal(id, returnValue.Id);
    }
}
