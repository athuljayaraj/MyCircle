using System.Globalization;

namespace MyCircle;

public class Friend
{
    public DateOnly Date { get; set; }
    public required string Country { get; set; }

    public string? Name { get; set; }

    public int Id { get; set; }
    public required int[] MutualFriends { get; set; }
}
