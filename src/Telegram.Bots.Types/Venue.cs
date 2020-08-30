namespace Telegram.Bots.Types
{
  public sealed class Venue
  {
    public string Title { get; set; } = null!;

    public string Address { get; set; } = null!;

    public Location Location { get; set; } = null!;

    public string? FoursquareId { get; set; }

    public string? FoursquareType { get; set; }
  }
}
