using Microsoft.AspNetCore.Mvc;
using ShipTrackApi.Models;

namespace ShipTrackApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShipmentsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll([FromQuery] string? status, [FromQuery] string? search)
    {
        var shipments = ShipmentData.Shipments.AsEnumerable();

        if (!string.IsNullOrEmpty(status))
            shipments = shipments.Where(s => s.Status == status);

        if (!string.IsNullOrEmpty(search))
            shipments = shipments.Where(s =>
                s.Id.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                s.SenderCity.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                s.RecipientCity.Contains(search, StringComparison.OrdinalIgnoreCase));

        return Ok(shipments);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var shipment = ShipmentData.Shipments.FirstOrDefault(s => s.Id == id);

        if (shipment is null)
            return NotFound();

        return Ok(shipment);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateShipmentRequest request)
    {
        var newId = $"CNT-2026-{Random.Shared.Next(10000, 99999)}";

        var shipment = new Shipment
        {
            Id = newId,
            SenderName = request.SenderName,
            SenderCity = request.SenderCity,
            RecipientName = request.RecipientName,
            RecipientCity = request.RecipientCity,
            Carrier = request.Carrier,
            Status = "pending",
            ETA = request.ETA,
            Weight = request.Weight,
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = DateTime.Now.ToString("d MMM, HH:mm"), Done = true },
                new TrackingEvent { Event = "Awaiting pickup", Time = "", Done = false, Active = true },
                new TrackingEvent { Event = "In transit", Time = "", Done = false },
                new TrackingEvent { Event = "Out for delivery", Time = "", Done = false },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        };

        ShipmentData.Shipments.Add(shipment);
        return CreatedAtAction(nameof(GetById), new { id = newId }, shipment);
    }

    [HttpGet("stats")]
    public IActionResult GetStats()
    {
        var last30Days = Enumerable.Range(0, 30)
            .Select(i => DateTime.Today.AddDays(-29 + i))
            .Select(date => new
            {
                date = date.ToString("dd MMM"),
                count = ShipmentData.Shipments.Count(s =>
                    s.History.Any(h =>
                        h.Event == "Order placed" &&
                        h.Time.StartsWith(date.Day + " " + date.ToString("MMM").ToLower())))
            })
            .ToList();

        return Ok(last30Days);
    }
}

public record CreateShipmentRequest(
    string SenderName,
    string SenderCity,
    string RecipientName,
    string RecipientCity,
    string Carrier,
    string ETA,
    double? Weight
);