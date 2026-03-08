namespace ShipTrackApi.Models;

public class Shipment
{
    public string Id { get; set; } = string.Empty;
    public string SenderName { get; set; } = string.Empty;
    public string SenderCity { get; set; } = string.Empty;
    public string RecipientName { get; set; } = string.Empty;
    public string RecipientCity { get; set; } = string.Empty;
    public string Carrier { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string ETA { get; set; } = string.Empty;
    public double? Weight { get; set; }
    public List<TrackingEvent> History { get; set; } = new();
}

public class TrackingEvent
{
    public string Event { get; set; } = string.Empty;
    public string Time { get; set; } = string.Empty;
    public bool Done { get; set; }
    public bool Active { get; set; }
}