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

public class EventsControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly EventsController _controller;

    public EventsControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new EventsController(_context);

        // Seed the in-memory database with test data
        SeedDatabase();
    }

    private void SeedDatabase()
    {
        var events = new List<CvgsEvent>
        {
            new CvgsEvent { Id = Guid.NewGuid(), EventName = "Event 1", EventDescription = "Description 1", EventDateTime = DateTime.Now.AddDays(1), IsDeleted = false },
            new CvgsEvent { Id = Guid.NewGuid(), EventName = "Event 2", EventDescription = "Description 2", EventDateTime = DateTime.Now.AddDays(2), IsDeleted = false },
            new CvgsEvent { Id = Guid.NewGuid(), EventName = "Event 3", EventDescription = "Description 3", EventDateTime = DateTime.Now.AddDays(-1), IsDeleted = false },
            new CvgsEvent { Id = Guid.NewGuid(), EventName = "Event 4", EventDescription = "Description 4", EventDateTime = DateTime.Now.AddDays(3), IsDeleted = true }
        };

        _context.CvgsEvents.AddRange(events);
        _context.SaveChanges();
    }

    [Fact]
    public async Task GetUpcomingEvent_ReturnsUpcomingEvents()
    {
        // Act
        var result = await _controller.GetUpcomingEvent();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<CvgsEvent>>>(result);
        var returnValue = Assert.IsType<List<CvgsEvent>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count); // Only two events are upcoming and not deleted
    }

    [Fact]
    public async Task GetCvgsEvent_ReturnsEvent_WhenEventExists()
    {
        // Arrange
        var existingEvent = _context.CvgsEvents.First();

        // Act
        var result = await _controller.GetCvgsEvent(existingEvent.Id);

        // Assert
        var actionResult = Assert.IsType<ActionResult<CvgsEvent>>(result);
        var returnValue = Assert.IsType<CvgsEvent>(actionResult.Value);
        Assert.Equal(existingEvent.Id, returnValue.Id);
    }

    [Fact]
    public async Task GetCvgsEvent_ReturnsNotFound_WhenEventDoesNotExist()
    {
        // Act
        var result = await _controller.GetCvgsEvent(Guid.NewGuid());

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task PostCvgsEvent_AddsEvent_ReturnsCreatedAtAction()
    {
        // Arrange
        var newEvent = new CvgsEvent
        {
            Id = Guid.NewGuid(),
            EventName = "New Event",
            EventDescription = "New Description",
            EventDateTime = DateTime.Now.AddDays(5),
            IsDeleted = false
        };

        // Act
        var result = await _controller.PostCvgsEvent(newEvent);

        // Assert
        var actionResult = Assert.IsType<ActionResult<CvgsEvent>>(result);
        var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
        var returnValue = Assert.IsType<CvgsEvent>(createdAtActionResult.Value);
        Assert.Equal(newEvent.Id, returnValue.Id);
        Assert.Equal("GetCvgsEvent", createdAtActionResult.ActionName);
    }

    [Fact]
    public async Task DeleteCvgsEvent_SetsIsDeletedToTrue_WhenEventExists()
    {
        // Arrange
        var existingEvent = _context.CvgsEvents.First(e => !e.IsDeleted);

        // Act
        var result = await _controller.DeleteCvgsEvent(existingEvent.Id);

        // Assert
        Assert.IsType<NoContentResult>(result);
        var deletedEvent = await _context.CvgsEvents.FindAsync(existingEvent.Id);
        Assert.True(deletedEvent.IsDeleted);
    }

    [Fact]
    public async Task DeleteCvgsEvent_ReturnsNotFound_WhenEventDoesNotExist()
    {
        // Act
        var result = await _controller.DeleteCvgsEvent(Guid.NewGuid());

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }
}
