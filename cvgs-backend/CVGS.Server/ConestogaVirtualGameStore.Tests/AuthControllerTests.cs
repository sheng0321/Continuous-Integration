using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.UI.Services;
using ConestogaVirtualGameStore.Server.Controllers;
using ConestogaVirtualGameStore.Server.Data.Models;
using ConestogaVirtualGameStore.Server.Data.ViewModels;
using ConestogaVirtualGameStore.Server.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Routing;

public class AuthControllerTests
{
    private readonly Mock<UserManager<ApplicationUser>> _userManager;
    private readonly Mock<SignInManager<ApplicationUser>> _signInManager;
    private readonly Mock<IConfiguration> _configuration;
    private readonly ApplicationDbContext _context;
    private readonly Mock<IEmailSender> _emailSender;
    private readonly AuthController _controller;

    public AuthControllerTests()
    {
        var userStore = new Mock<IUserStore<ApplicationUser>>();
        _userManager = new Mock<UserManager<ApplicationUser>>(userStore.Object, null, null, null, null, null, null, null, null);
        var contextAccessor = new Mock<IHttpContextAccessor>();
        var userPrincipalFactory = new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>();
        _signInManager = new Mock<SignInManager<ApplicationUser>>(_userManager.Object, contextAccessor.Object, userPrincipalFactory.Object, null, null, null, null);
        _configuration = new Mock<IConfiguration>();
        _emailSender = new Mock<IEmailSender>();

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _controller = new AuthController(_userManager.Object, _signInManager.Object, _configuration.Object, _context, _emailSender.Object);

        // Ensure the database is clean before seeding
        ClearDatabase();

        // Seed the in-memory database with test data
        SeedDatabase();

        // Setup configuration values
        SetupConfiguration();
        // Mock HttpContext
        var httpContextMock = new Mock<HttpContext>();
        var httpRequestMock = new Mock<HttpRequest>();
        httpRequestMock.Setup(r => r.Scheme).Returns("http");
        httpContextMock.Setup(c => c.Request).Returns(httpRequestMock.Object);

        _controller.ControllerContext = new ControllerContext()
        {
            HttpContext = httpContextMock.Object
        };
        // Mock UrlHelper
        var urlHelperMock = new Mock<IUrlHelper>();
        urlHelperMock.Setup(u => u.Action(It.IsAny<UrlActionContext>())).Returns("http://localhost:5000/confirm-email");
        _controller.Url = urlHelperMock.Object;
    }

    private void ClearDatabase()
    {
        _context.UserProfiles.RemoveRange(_context.UserProfiles);
        _context.Users.RemoveRange(_context.Users);
        _context.SaveChanges();
    }

    private void SeedDatabase()
    {
        // Add any necessary seeding here if needed
    }

    private void SetupConfiguration()
    {
        _configuration.SetupGet(c => c["Jwt:Key"]).Returns("ECD8C569-59E6-4932-8B36-15D071607150");
        _configuration.SetupGet(c => c["Jwt:Issuer"]).Returns("https://localhost:7245");
        _configuration.SetupGet(c => c["Jwt:Audience"]).Returns("https://localhost:7245");
    }

    private Mock<DbSet<T>> CreateMockDbSet<T>(IQueryable<T> data) where T : class
    {
        var mockSet = new Mock<DbSet<T>>();
        mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(new TestAsyncQueryProvider<T>(data.Provider));
        mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
        mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
        mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
        mockSet.As<IAsyncEnumerable<T>>().Setup(m => m.GetAsyncEnumerator(It.IsAny<CancellationToken>())).Returns(new TestAsyncEnumerator<T>(data.GetEnumerator()));
        return mockSet;
    }

    [Fact]
    
    public async Task Register_ValidData_ReturnsOk()
    {
        // Arrange
        var model = new RegisterModel
        {
            DisplayName = "TestUser",
            Email = "testuser@example.com",
            Password = "Test@1234"
        };

        _userManager.Setup(um => um.Users).Returns(_context.Users);
        _userManager.Setup(um => um.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);
        _userManager.Setup(um => um.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);
        _userManager.Setup(um => um.GenerateEmailConfirmationTokenAsync(It.IsAny<ApplicationUser>())).ReturnsAsync("test-code");
        _emailSender.Setup(es => es.SendEmailAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.CompletedTask);

        // Act
        var result = await _controller.Register(model);

        // Assert
        var objectResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(200, objectResult.StatusCode);
    }



    [Fact]
    public async Task Login_ValidData_ReturnsToken()
    {
        // Arrange
        // Arrange
        var model = new LoginModel
        {
            Email = "testuser@example.com",
            Password = "Test@1234"
        };

        var user = new ApplicationUser
        {
            Email = model.Email,
            UserName = model.Email,
            DisplayName = "TestUser"
        };

        _userManager.Setup(um => um.FindByEmailAsync(model.Email)).ReturnsAsync(user);
        _userManager.Setup(um => um.IsEmailConfirmedAsync(user)).ReturnsAsync(true);
        _userManager.Setup(um => um.CheckPasswordAsync(user, model.Password)).ReturnsAsync(true);
        _userManager.Setup(um => um.GetRolesAsync(user)).ReturnsAsync(new List<string> { "Member" });

        // Act
        var result = await _controller.Login(model);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var token = Assert.IsType<string>(okResult.Value.GetType().GetProperty("Token").GetValue(okResult.Value, null));
        Assert.NotNull(token);
    }

    [Fact]
    public async Task UpdatePassword_ValidData_ReturnsOk()
    {  
        // Arrange
        var model = new UpdatePasswordModel
        {
            Email = "testuser@example.com",
            CurrentPassword = "Test@1234",
            NewPassword = "NewTest@1234"
        };

        var user = new ApplicationUser { Email = model.Email, UserName = model.Email, DisplayName = "TestUser" };

        _userManager.Setup(um => um.FindByEmailAsync(model.Email)).ReturnsAsync(user);
        _userManager.Setup(um => um.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword)).ReturnsAsync(IdentityResult.Success);

        // Act
        var result = await _controller.UpdatePassword(model);

        // Assert
        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public async Task ConfirmEmail_ValidData_ReturnsOk()
    {
        // Arrange
        var userId = "test-user-id";
        var code = "test-code";
        var user = new ApplicationUser { Id = userId, Email = "testuser@example.com", UserName = "testuser@example.com", DisplayName = "TestUser" };

        _userManager.Setup(um => um.FindByIdAsync(userId)).ReturnsAsync(user);
        _userManager.Setup(um => um.ConfirmEmailAsync(user, code)).ReturnsAsync(IdentityResult.Success);

        // Act
        var result = await _controller.ConfirmEmail(userId, code);

        // Assert
        Assert.IsType<OkObjectResult>(result);
    }
}

public class TestAsyncQueryProvider<TEntity> : IAsyncQueryProvider
{
    private readonly IQueryProvider _inner;

    public TestAsyncQueryProvider(IQueryProvider inner)
    {
        _inner = inner;
    }

    public IQueryable CreateQuery(Expression expression)
    {
        return new TestAsyncEnumerable<TEntity>(expression);
    }

    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        return new TestAsyncEnumerable<TElement>(expression);
    }

    public object Execute(Expression expression)
    {
        return _inner.Execute(expression);
    }

    public TResult Execute<TResult>(Expression expression)
    {
        return _inner.Execute<TResult>(expression);
    }

    public IAsyncEnumerable<TResult> ExecuteAsync<TResult>(Expression expression)
    {
        return new TestAsyncEnumerable<TResult>(expression);
    }

    public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
    {
        return Task.FromResult(_inner.Execute<TResult>(expression));
    }
}

public class TestAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
{
    public TestAsyncEnumerable(IEnumerable<T> enumerable)
        : base(enumerable)
    { }

    public TestAsyncEnumerable(Expression expression)
        : base(expression)
    { }

    public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
    {
        return new TestAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
    }

    IAsyncEnumerator<T> IAsyncEnumerable<T>.GetAsyncEnumerator(CancellationToken cancellationToken)
    {
        return GetAsyncEnumerator(cancellationToken);
    }

    IQueryProvider IQueryable.Provider
    {
        get { return new TestAsyncQueryProvider<T>(this); }
    }
}

public class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
{
    private readonly IEnumerator<T> _inner;

    public TestAsyncEnumerator(IEnumerator<T> inner)
    {
        _inner = inner;
    }

    public T Current => _inner.Current;

    public ValueTask DisposeAsync()
    {
        _inner.Dispose();
        return ValueTask.CompletedTask;
    }

    public ValueTask<bool> MoveNextAsync()
    {
        return new ValueTask<bool>(_inner.MoveNext());
    }
}

