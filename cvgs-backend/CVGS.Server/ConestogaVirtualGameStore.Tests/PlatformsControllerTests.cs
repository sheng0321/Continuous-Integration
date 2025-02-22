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

public class PlatformsControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly PlatformsController _controller;

    public PlatformsControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new PlatformsController(_context);
    }

    [Fact]
  
    public async Task GetFavoritePlatform_ReturnsAllPlatforms()
    {
        // Clear the FavoritePlatform table to ensure a clean state
        _context.FavoritePlatform.RemoveRange(_context.FavoritePlatform);
        await _context.SaveChangesAsync();

        // Arrange
        var platforms = new List<FavoritePlatform>
    {
        new FavoritePlatform { Id = Guid.NewGuid(), Name = "PC" },
        new FavoritePlatform { Id = Guid.NewGuid(), Name = "Xbox" }
    };

        _context.FavoritePlatform.AddRange(platforms);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetFavoritePlatform();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<FavoritePlatform>>>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<FavoritePlatform>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count());
    }



}
