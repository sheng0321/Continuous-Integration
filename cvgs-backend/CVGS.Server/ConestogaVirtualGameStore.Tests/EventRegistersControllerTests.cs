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

public class EventRegistersControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly EventRegistersController _controller;

    public EventRegistersControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new EventRegistersController(_context);
        ClearDatabase();
        SeedDatabase();
    }

    private void ClearDatabase()
    {
        _context.EventRegisters.RemoveRange(_context.EventRegisters);
        _context.SaveChanges();
    }

    private void SeedDatabase()
    {
        var eventRegister1 = new EventRegister
        {
            Id = Guid.NewGuid(),
            EventId = Guid.NewGuid(),
            MemberId = "member1",
            CreatedDate = DateTime.UtcNow,
            IsCancel = false
        };

        var eventRegister2 = new EventRegister
        {
            Id = Guid.NewGuid(),
            EventId = Guid.NewGuid(),
            MemberId = "member2",
            CreatedDate = DateTime.UtcNow,
            IsCancel = false
        };

        _context.EventRegisters.AddRange(eventRegister1, eventRegister2);
        _context.SaveChanges();
    }

    [Fact]
    public async Task GetEventRegisters_ReturnsAllEventRegisters()
    {
        // Act
        var result = await _controller.GetEventRegister();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<EventRegister>>>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<EventRegister>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count());
    }

    [Fact]
    public async Task GetEventRegister_ReturnsNotFound_WhenEventRegisterDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.GetEventRegister(id);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task PostEventRegister_CreatesEventRegister_WhenValid()
    {
        // Arrange
        var eventRegister = new EventRegister
        {
            Id = Guid.NewGuid(),
            EventId = Guid.NewGuid(),
            MemberId = "member3",
            CreatedDate = DateTime.UtcNow,
            IsCancel = false
        };

        // Act
        var result = await _controller.PostEventRegister(eventRegister);

        // Assert
        var actionResult = Assert.IsType<ActionResult<EventRegister>>(result);
        var createdResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
        Assert.Equal(eventRegister.Id, ((EventRegister)createdResult.Value).Id);
    }

    [Fact]
    public async Task PutEventRegister_ReturnsNoContent_WhenUpdateIsSuccessful()
    {
        // Arrange
        var id = Guid.NewGuid();
        var eventRegister = new EventRegister
        {
            Id = id,
            EventId = Guid.NewGuid(),
            MemberId = "member1",
            CreatedDate = DateTime.UtcNow,
            IsCancel = false
        };
        _context.EventRegisters.Add(eventRegister);
        await _context.SaveChangesAsync();

        // Update the event register
        eventRegister.IsCancel = true;

        // Act
        var result = await _controller.PutEventRegister(id, eventRegister);

        // Assert
        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteEventRegister_ReturnsNotFound_WhenEventRegisterDoesNotExist()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        var result = await _controller.DeleteEventRegister(id);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public async Task DeleteEventRegister_ReturnsNoContent_WhenDeleted()
    {
        // Arrange
        var id = Guid.NewGuid();
        var eventRegister = new EventRegister
        {
            Id = id,
            EventId = Guid.NewGuid(),
            MemberId = "member1",
            CreatedDate = DateTime.UtcNow,
            IsCancel = false
        };
        _context.EventRegisters.Add(eventRegister);
        await _context.SaveChangesAsync();

        // Act
        var result = await _controller.DeleteEventRegister(id);

        // Assert
        Assert.IsType<NoContentResult>(result);
        Assert.Null(await _context.EventRegisters.FindAsync(id));
    }
}
