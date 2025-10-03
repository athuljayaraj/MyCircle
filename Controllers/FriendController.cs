using Microsoft.AspNetCore.Mvc;

namespace MyCircle.Controllers;

[ApiController]
[Route("[controller]")]
public class FriendController : ControllerBase
{
    private static readonly Friend[] Friends = new[]
    {
        new Friend { Name = "Alice", Country = "USA", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-1)) },
        new Friend { Name = "Bob", Country = "Canada", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-2)) },
        new Friend { Name = "Charlie", Country = "UK", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-3)) },
        new Friend { Name = "David", Country = "Australia", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-4)) },
        new Friend { Name = "Eva", Country = "Germany", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-5)) }
    };

    private readonly ILogger<FriendController> _logger;

    public FriendController(ILogger<FriendController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetFriends")]
    public IEnumerable<Friend> Get()
    {
        return Friends;
    }
}
