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

public class LanguagesControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly LanguagesController _controller;

    public LanguagesControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new LanguagesController(_context);
    }

    [Fact]
    public async Task GetLanguage_ReturnsAllLanguages()
    {
        // Clear the Language table to ensure a clean state
        _context.Language.RemoveRange(_context.Language);
        await _context.SaveChangesAsync();
        // Arrange
        var languages = new List<Language>
        {
            new Language { Id = Guid.NewGuid(), Name = "English" },
            new Language { Id = Guid.NewGuid(), Name = "Spanish" }
        };

        _context.Language.AddRange(languages);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetLanguage();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<Language>>>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<Language>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count());
    }
}
