using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using ConestogaVirtualGameStore.Server.Controllers;
using ConestogaVirtualGameStore.Server.Data;
using ConestogaVirtualGameStore.Server.Data.Models;
using ConestogaVirtualGameStore.Server.Data.ViewModels;

namespace ConestogaVirtualGameStore.Tests
{


    public class GamesControllerTests
    {
        private readonly GamesController _controller;
        private readonly ApplicationDbContext _context;

        public GamesControllerTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _controller = new GamesController(_context);
        }

        [Fact]
        public async Task GetGames_ReturnsOkResult_WithGames()
        {
            // Arrange
            _context.Games.RemoveRange(_context.Games); // Clear existing games
            await _context.SaveChangesAsync(); // Ensure the context is updated
                                               // Create and add a GameCategory
            var categoryId = Guid.NewGuid(); // Create a new category ID
            var gameCategory = new GameCategory
            {
                Id = categoryId,
                Name = "Action" // Example category name
            };
            var games = new List<Game>

    {
        new Game
        {
            Id = Guid.NewGuid(),
            GameName = "Game1",
            Overview = "Overview of Game1",
            ThumbnailPath = "path/to/image1.jpg",
            GameCategoryId = categoryId,
            Price = 29.99m,
            GamesInStock = 5
        },
        new Game
        {
            Id = Guid.NewGuid(),
            GameName = "Game2",
            Overview = "Overview of Game2",
            ThumbnailPath = "path/to/image2.jpg",
            GameCategoryId = categoryId,
            Price = 49.99m,
            GamesInStock = 10
        }
    };
            _context.GameCategories.Add(gameCategory);
            _context.Games.AddRange(games); // Add new games
            await _context.SaveChangesAsync(); // Persist the new games

            // Act
            var result = await _controller.GetGames();

            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Game>>>(result);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);

            // Since the actual return type is an anonymous type, we can use dynamic
            var returnGames = Assert.IsAssignableFrom<IEnumerable<dynamic>>(okResult.Value);
            Assert.Equal(2, returnGames.Count());
        }

        [Fact]
        public async Task GetGame_ExistingId_ReturnsOkResult_WithGame()
        {

            // Arrange
            _context.Games.RemoveRange(_context.Games); // Clear existing games
            _context.GameCategories.RemoveRange(_context.GameCategories); // Clear existing categories
            await _context.SaveChangesAsync(); // Ensure the context is updated

            // Create and add a GameCategory
            var categoryId = Guid.NewGuid(); // Create a new category ID
            var gameCategory = new GameCategory
            {
                Id = categoryId,
                Name = "Action" // Example category name
            };

            _context.GameCategories.Add(gameCategory); // Add the category to the context
            await _context.SaveChangesAsync(); // Persist the new category

            // Create and add a Game
            var gameId = Guid.NewGuid(); // Create a new game ID
            var game = new Game
            {
                Id = gameId,
                GameName = "Game1",
                Overview = "Overview of Game1",
                ThumbnailPath = "path/to/image1.jpg",
                Price = 29.99m,
                GamesInStock = 5,
                GameCategoryId = categoryId, // Set the foreign key to the added category
                IsDelete = false // Ensure the game is not marked as deleted
            };

            _context.Games.Add(game); // Add the game instance to the context
            await _context.SaveChangesAsync(); // Persist the new game

            // Act
            var result = await _controller.GetGame(gameId); // Call the method to get the game

            // Assert
            var okResult = Assert.IsType<ActionResult<Game>>(result); // Assert the result type
            var returnGame = Assert.IsType<Game>(okResult.Value); // Assert the returned game type
            Assert.Equal(gameId, returnGame.Id); // Verify the game ID matches
        }

        [Fact]
        public async Task PostGame_ValidModel_ReturnsCreatedAtAction()
        {
            // Arrange
            var model = new GameAddModel
            {
                GameName = "New Game",
                Overview = "Overview",
                Price = 59.99m,
                GameCategoryId = Guid.NewGuid(),
                GamesInStock = 10,
                ThumbnailPath = "path/to/image"
            };

            var category = new GameCategory { Id = model.GameCategoryId };
            _context.GameCategories.Add(category);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.PostGame(model);

            // Assert
            var actionResult = Assert.IsType<ActionResult<Game>>(result);
            var createdResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
            Assert.Equal("GetGame", createdResult.ActionName);
            Assert.NotNull(createdResult.Value);
        }

        [Fact]
        public async Task PutGame_ValidId_ReturnsNoContent()
        {
            // Arrange
            var gameId = Guid.NewGuid();
            var game = new Game { Id = gameId, GameName = "Updated Game", GameCategoryId = Guid.NewGuid() };
            var category = new GameCategory { Id = game.GameCategoryId };

            _context.GameCategories.Add(category);
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.PutGame(gameId, game);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task DeleteGame_ExistingId_ReturnsNoContent()
        {
            // Arrange
            var gameId = Guid.NewGuid();
            var game = new Game { Id = gameId, IsDelete = false };

            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.DeleteGame(gameId);

            // Assert
            Assert.IsType<NoContentResult>(result);
            Assert.True(game.IsDelete); // Ensure the game is marked as deleted
        }
    }
}
