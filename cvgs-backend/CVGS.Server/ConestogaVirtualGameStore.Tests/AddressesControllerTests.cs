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

public class AddressesControllerTests
{
    private readonly ApplicationDbContext _context;
    private readonly AddressesController _controller;

    public AddressesControllerTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new AddressesController(_context);
        ClearDatabase();
        // Seed the in-memory database with test data
        SeedDatabase();
    }
    private void ClearDatabase()
    {
        _context.Addresses.RemoveRange(_context.Addresses);
        _context.SaveChanges();
    }

    private void SeedDatabase()
    {
        var addresses = new List<Address>
        {
            new Address { AddressID = Guid.NewGuid(), MemberID = "1", FullName = "John Doe", StreetAddress = "123 Main St", City = "Waterloo", Province = "ON", PostalCode = "N2L 3G1", Country = "Canada", PhoneNumber = "1234567890" },
            new Address { AddressID = Guid.NewGuid(), MemberID = "2", FullName = "Jane Smith", StreetAddress = "456 Elm St", City = "Waterloo", Province = "ON", PostalCode = "N2L 3G2", Country = "Canada", PhoneNumber = "0987654321" }
        };

        _context.Addresses.AddRange(addresses);
        _context.SaveChanges();
    }

    [Fact]
    public async Task GetAddresses_ReturnsAllAddresses()
    {
        // Act
        var result = await _controller.GetAddresses();

        // Assert
        var actionResult = Assert.IsType<ActionResult<IEnumerable<Address>>>(result);
        var returnValue = Assert.IsType<List<Address>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count); // Two addresses in the seed data
    }

    [Fact]
    public async Task GetAddress_ReturnsAddress_WhenAddressExists()
    {
        // Arrange
        var existingAddress = _context.Addresses.First();

        // Act
        var result = await _controller.GetAddress(existingAddress.AddressID);

        // Assert
        var actionResult = Assert.IsType<ActionResult<Address>>(result);
        var returnValue = Assert.IsType<Address>(actionResult.Value);
        Assert.Equal(existingAddress.AddressID, returnValue.AddressID);
    }

    [Fact]
    public async Task GetAddress_ReturnsNotFound_WhenAddressDoesNotExist()
    {
        // Act
        var result = await _controller.GetAddress(Guid.NewGuid());

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }

    

    [Fact]
    public async Task PutAddress_ReturnsBadRequest_WhenIdMismatch()
    {
        // Arrange
        var existingAddress = _context.Addresses.First();
        var updatedAddress = new Address
        {
            AddressID = Guid.NewGuid(), // Different ID
            MemberID = existingAddress.MemberID,
            FullName = "Updated Name",
            StreetAddress = "Updated Address",
            City = "Updated City",
            Province = "Updated Province",
            PostalCode = "Updated PostalCode",
            Country = "Updated Country",
            PhoneNumber = "Updated PhoneNumber"
        };

        // Act
        var result = await _controller.PutAddress(existingAddress.AddressID, updatedAddress);

        // Assert
        Assert.IsType<BadRequestResult>(result);
    }

    [Fact]
    public async Task DeleteAddress_DeletesAddress_WhenAddressExists()
    {
        // Arrange
        var existingAddress = _context.Addresses.First();

        // Act
        var result = await _controller.DeleteAddress(existingAddress.AddressID);

        // Assert
        Assert.IsType<NoContentResult>(result);
        var addressInDb = await _context.Addresses.FindAsync(existingAddress.AddressID);
        Assert.Null(addressInDb);
    }

    [Fact]
    public async Task DeleteAddress_ReturnsNotFound_WhenAddressDoesNotExist()
    {
        // Act
        var result = await _controller.DeleteAddress(Guid.NewGuid());

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }
}
