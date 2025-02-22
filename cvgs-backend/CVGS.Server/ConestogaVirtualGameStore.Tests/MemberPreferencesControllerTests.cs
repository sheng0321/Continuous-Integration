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
using Microsoft.CodeAnalysis;

namespace ConestogaVirtualGameStore.Tests
{
    public class MemberPreferencesControllerTests
    {
        private readonly MemberPreferencesController _controller;
        private readonly ApplicationDbContext _context;

        public MemberPreferencesControllerTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _controller = new MemberPreferencesController(_context);
        }

        [Fact]
        public async Task GetMemberPreferences_ReturnsOkResult_WithPreferences()
        {
            // Arrange
           
            _context.MemberPreference.RemoveRange(_context.MemberPreference); 
            await _context.SaveChangesAsync();
         
            var platformId = Guid.NewGuid();
            var gameCategoryId = Guid.NewGuid();
            var languageId = Guid.NewGuid();

            // Seed related entities
            var favoritePlatform = new FavoritePlatform { Id = platformId, Name = "PC" };
            var gameCategory = new GameCategory { Id = gameCategoryId, Name = "Action" };
            var language = new Language { Id = languageId, Name = "English" };

            _context.FavoritePlatform.Add(favoritePlatform);
            _context.GameCategories.Add(gameCategory);
            _context.Language.Add(language);
            await _context.SaveChangesAsync();

            // Create member preferences
            var memberPreferences = new List<MemberPreference>
    {
        new MemberPreference { Id = Guid.NewGuid(), MemberId = "member1", PlatformId = platformId, GameCategoryId = gameCategoryId, LanguageId = languageId, UpdateTime = DateTime.UtcNow },
        new MemberPreference { Id = Guid.NewGuid(), MemberId = "member2", PlatformId = platformId, GameCategoryId = gameCategoryId, LanguageId = languageId, UpdateTime = DateTime.UtcNow }
    };

            _context.MemberPreference.AddRange(memberPreferences);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.GetMemberPreferences();

            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<MemberPreference>>>(result);
                  
            Assert.Equal(2, actionResult.Value.Count());
        }

        [Fact]
        public async Task GetMemberPreference_ExistingId_ReturnsOkResult_WithPreference()
        {
            // Arrange
            _context.MemberPreference.RemoveRange(_context.MemberPreference);
            await _context.SaveChangesAsync();
            // Seed related entities
            var platformId = Guid.NewGuid();
            var gameCategoryId = Guid.NewGuid();
            var languageId = Guid.NewGuid();
            var favoritePlatform = new FavoritePlatform { Id = platformId, Name = "PC" };
            var gameCategory = new GameCategory { Id = gameCategoryId, Name = "Action" };
            var language = new Language { Id = languageId, Name = "English" };

            _context.FavoritePlatform.Add(favoritePlatform);
            _context.GameCategories.Add(gameCategory);
            _context.Language.Add(language);
            await _context.SaveChangesAsync();
            var memberPreference = new MemberPreference { Id = Guid.NewGuid(), MemberId = "member1", PlatformId = platformId, GameCategoryId = gameCategoryId, LanguageId = languageId, UpdateTime = DateTime.UtcNow };
            _context.MemberPreference.Add(memberPreference);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.GetMemberPreference(memberPreference.Id);

            // Assert
            var okResult = Assert.IsType<ActionResult<MemberPreference>>(result);
            var returnPreference = Assert.IsType<MemberPreference>(okResult.Value);
            Assert.Equal(memberPreference.Id, returnPreference.Id);
        }

        [Fact]
        public async Task PostMemberPreference_ValidModel_ReturnsCreatedAtAction()
        {
            // Arrange
            _context.MemberPreference.RemoveRange(_context.MemberPreference);
            await _context.SaveChangesAsync();
            // Seed related entities
            var platformId = Guid.NewGuid();
            var gameCategoryId = Guid.NewGuid();
            var languageId = Guid.NewGuid();
            var favoritePlatform = new FavoritePlatform { Id = platformId, Name = "PC" };
            var gameCategory = new GameCategory { Id = gameCategoryId, Name = "Action" };
            var language = new Language { Id = languageId, Name = "English" };
            _context.FavoritePlatform.Add(favoritePlatform);
            _context.GameCategories.Add(gameCategory);
            _context.Language.Add(language);
            await _context.SaveChangesAsync();

            var memberPreference = new MemberPreference
            {
                Id = Guid.NewGuid(),
                MemberId = "member1",
                PlatformId = platformId,
                GameCategoryId = gameCategoryId,
                LanguageId = languageId,
                UpdateTime = DateTime.UtcNow
            };

            // Act
            var result = await _controller.PostMemberPreference(memberPreference);

            // Assert
            var actionResult = Assert.IsType<ActionResult<MemberPreference>>(result);
            var createdResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
            Assert.Equal("GetMemberPreference", createdResult.ActionName);
            Assert.NotNull(createdResult.Value);
        }

        [Fact]
        public async Task PutMemberPreference_ValidId_ReturnsOkResult()
        {
            // Arrange
            _context.MemberPreference.RemoveRange(_context.MemberPreference);
            await _context.SaveChangesAsync();
            // Seed related entities
            var platformId = Guid.NewGuid();
            var gameCategoryId = Guid.NewGuid();
            var languageId = Guid.NewGuid();
            var favoritePlatform = new FavoritePlatform { Id = platformId, Name = "PC" };
            var gameCategory = new GameCategory { Id = gameCategoryId, Name = "Action" };
            var language = new Language { Id = languageId, Name = "English" };
            _context.FavoritePlatform.Add(favoritePlatform);
            _context.GameCategories.Add(gameCategory);
            _context.Language.Add(language);
            await _context.SaveChangesAsync();
            var memberPreference = new MemberPreference { Id = Guid.NewGuid(), MemberId = "member1", PlatformId = platformId, GameCategoryId = gameCategoryId, LanguageId = languageId, UpdateTime = DateTime.UtcNow };
            _context.MemberPreference.Add(memberPreference);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.PutMemberPreference(memberPreference);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(memberPreference.Id, ((MemberPreference)okResult.Value).Id);
        }

        [Fact]
        public async Task DeleteMemberPreference_ExistingId_ReturnsNoContent()
        {
            // Arrange
            _context.MemberPreference.RemoveRange(_context.MemberPreference);
            await _context.SaveChangesAsync();
            // Seed related entities
            var platformId = Guid.NewGuid();
            var gameCategoryId = Guid.NewGuid();
            var languageId = Guid.NewGuid();
            var favoritePlatform = new FavoritePlatform { Id = platformId, Name = "PC" };
            var gameCategory = new GameCategory { Id = gameCategoryId, Name = "Action" };
            var language = new Language { Id = languageId, Name = "English" };
            _context.FavoritePlatform.Add(favoritePlatform);
            _context.GameCategories.Add(gameCategory);
            _context.Language.Add(language);
            await _context.SaveChangesAsync();
            var memberPreference = new MemberPreference { Id = Guid.NewGuid(), MemberId = "member1", PlatformId = platformId, GameCategoryId = gameCategoryId, LanguageId = languageId, UpdateTime = DateTime.UtcNow };
            _context.MemberPreference.Add(memberPreference);
            await _context.SaveChangesAsync();

            // Act
            var result = await _controller.DeleteMemberPreference(memberPreference.Id);

            // Assert
            Assert.IsType<NoContentResult>(result);
            var deletedPreference = await _context.MemberPreference.FindAsync(memberPreference.Id);
            Assert.Null(deletedPreference); // Ensure the preference is deleted
        }
    }
}