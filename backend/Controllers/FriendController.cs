using Microsoft.AspNetCore.Mvc;

namespace MyCircle.Controllers;

[ApiController]
[Route("[controller]")]
public class FriendController : ControllerBase
{
    private static readonly Friend[] Friends = new[]
    {
        new Friend { Id = 1, Name = "Bhagya", Country = "India", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-1)), MutualFriends = Array.Empty<int>() },
        new Friend { Id = 2, Name = "Hari", Country = "India", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-2)), MutualFriends = Array.Empty<int>() },
        new Friend { Id = 3, Name = "Emilie", Country = "France", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-3)), MutualFriends = Array.Empty<int>() },
        new Friend { Id = 4, Name = "Romain", Country = "France", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-4)), MutualFriends = Array.Empty<int>() },
        new Friend { Id = 5, Name = "Arielle", Country = "Canada", Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-5)), MutualFriends = Array.Empty<int>() }
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
