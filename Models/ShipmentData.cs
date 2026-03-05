namespace ShipTrackApi.Models;

public static class ShipmentData
{
    public static List<Shipment> Shipments { get; } = new()
    {
        new Shipment
        {
            Id = "CNT-2025-00142",
            SenderName = "Volvo AB",
            SenderCity = "Göteborg",
            RecipientName = "Scania Parts",
            RecipientCity = "Stockholm",
            Carrier = "DHL",
            Status = "transit",
            ETA = "5 mar 2025",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "1 mar, 09:12", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "2 mar, 14:30", Done = true },
                new TrackingEvent { Event = "In transit", Time = "3 mar, 08:00", Done = false, Active = true },
                new TrackingEvent { Event = "Out for delivery", Time = "", Done = false },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },
        new Shipment
        {
            Id = "CNT-2025-00139",
            SenderName = "IKEA Sverige",
            SenderCity = "Älmhult",
            RecipientName = "Privatkund",
            RecipientCity = "Malmö",
            Carrier = "PostNord",
            Status = "delivered",
            ETA = "2 mar 2025",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "28 feb, 10:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "28 feb, 16:45", Done = true },
                new TrackingEvent { Event = "In transit", Time = "1 mar, 07:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "2 mar, 09:30", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "2 mar, 13:47", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2025-00136",
            SenderName = "H&M Logistik",
            SenderCity = "Stockholm",
            RecipientName = "Butik Väst",
            RecipientCity = "Göteborg",
            Carrier = "Bring",
            Status = "delayed",
            ETA = "4 mar 2025",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "28 feb, 08:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "1 mar, 12:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "2 mar, 06:00", Done = true },
                new TrackingEvent { Event = "Delayed – weather", Time = "3 mar, 11:00", Done = false, Active = true },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },
        new Shipment
        {
            Id = "CNT-2025-00155",
            SenderName = "Kappahl",
            SenderCity = "Mölndal",
            RecipientName = "Butik Nord",
            RecipientCity = "Umeå",
            Carrier = "PostNord",
            Status = "pending",
            ETA = "8 mar 2025",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "4 mar, 16:22", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "", Done = false, Active = true },
                new TrackingEvent { Event = "In transit", Time = "", Done = false },
                new TrackingEvent { Event = "Out for delivery", Time = "", Done = false },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },
        new Shipment
        {
            Id = "CNT-2025-00157",
            SenderName = "Sandvik AB",
            SenderCity = "Sandviken",
            RecipientName = "Atlas Copco",
            RecipientCity = "Nacka",
            Carrier = "DHL",
            Status = "transit",
            ETA = "7 mar 2025",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "4 mar, 08:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "4 mar, 15:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "5 mar, 07:00", Done = false, Active = true },
                new TrackingEvent { Event = "Out for delivery", Time = "", Done = false },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        }
    };
}