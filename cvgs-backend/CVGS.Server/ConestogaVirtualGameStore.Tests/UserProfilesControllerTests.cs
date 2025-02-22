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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class UserProfilesControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly UserProfilesController _controller;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserProfilesControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _userManager = new UserManager<ApplicationUser>(
            new UserStore<ApplicationUser>(_context),
            null, null, null, null, null, null, null, null);
        _controller = new UserProfilesController(_context, _userManager);
    }

    [Fact]
    public async Task GetUserProfiles_ReturnsAllUserProfiles()
    {
        // Clear the UserProfiles table to ensure a clean state
        _context.UserProfiles.RemoveRange(_context.UserProfiles);
        await _context.SaveChangesAsync();

        // Arrange
        var userProfiles = new List<UserProfile>
        {
            new UserProfile { UserId = "user1", DisplayName = "User One" ,Email="test1@test.com"},
            new UserProfile { UserId = "user2", DisplayName = "User Two" ,Email="test2@test.com"}
        };

        _context.UserProfiles.AddRange(userProfiles);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetUserProfiles();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<UserProfile>>>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<UserProfile>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count());
    }

    [Fact]
    public async Task GetUserProfile_ReturnsNotFound_WhenUserProfileDoesNotExist()
    {

        // Arrange
        var id = "nonexistent";

        // Act
        var result = await _controller.GetUserProfile(id);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task GetUserProfile_ReturnsUserProfile_WhenExists()
    {
        // Clear the UserProfiles table to ensure a clean state
        _context.UserProfiles.RemoveRange(_context.UserProfiles);
        await _context.SaveChangesAsync();
        // Arrange
        var id = "user1";
        var userProfile = new UserProfile { UserId = id, DisplayName = "User One",Email="test@test.com" };
        _context.UserProfiles.Add(userProfile);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.GetUserProfile(id);

        // Assert
        var actionResult = Assert.IsType<ActionResult<UserProfile>>(result);
        var returnValue = Assert.IsType<UserProfile>(actionResult.Value);
        Assert.Equal(id, returnValue.UserId);
    }

    [Fact]
    public async Task PostUserProfile_CreatesUserProfile_WhenValid()
    {
        // Clear the UserProfiles table to ensure a clean state
        _context.UserProfiles.RemoveRange(_context.UserProfiles);
        await _context.SaveChangesAsync();
        // Arrange
        var userProfile = new UserProfile
        {
            UserId = "user3",
            DisplayName = "User Three",
            Email="test@test.com"
        };

        // Act
        var result = await _controller.PostUserProfile(userProfile);

        // Assert
        var actionResult = Assert.IsType<ActionResult<UserProfile>>(result);
        var createdResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
        Assert.Equal(userProfile.UserId, ((UserProfile)createdResult.Value).UserId);
    }

    [Fact]
    public async Task PutUserProfile_ReturnsNoContent_WhenUpdateIsSuccessful()
    {
        // Clear the UserProfiles table to ensure a clean state
        _context.UserProfiles.RemoveRange(_context.UserProfiles);
        await _context.SaveChangesAsync();
        // Arrange
        var id = "user1";
        var userProfile = new UserProfile { UserId = id, DisplayName = "User One" ,Email = "test@test.com" };
        _context.UserProfiles.Add(userProfile);
        await _context.SaveChangesAsync();

        // Update the user profile
        userProfile.DisplayName = "Updated User One";

        // Act
        var result = await _controller.PutUserProfile(id, userProfile);

        // Assert
        Assert.IsType<ActionResult<UserProfile>>(result);
    }

    [Fact]
    public async Task DeleteUserProfile_ReturnsNotFound_WhenUserProfileDoesNotExist()
    {
        // Arrange
        var id = "nonexistent";

        // Act
        var result = await _controller.DeleteUserProfile(id);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public async Task DeleteUserProfile_ReturnsNoContent_WhenDeleted()
    {  // Clear the UserProfiles table to ensure a clean state
        _context.UserProfiles.RemoveRange(_context.UserProfiles);
        await _context.SaveChangesAsync();
        // Arrange
        var id = "user1";
        var userProfile = new UserProfile { UserId = id, DisplayName = "User One" ,Email="test@test.com"};
        _context.UserProfiles.Add(userProfile);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.DeleteUserProfile(id);

        // Assert
        Assert.IsType<NoContentResult>(result);
        Assert.Null(await _context.UserProfiles.FindAsync(id));
    }
}
