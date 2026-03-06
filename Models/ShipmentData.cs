namespace ShipTrackApi.Models;

public static class ShipmentData
{
    public static List<Shipment> Shipments { get; } = new()
    {
        // 6 mar 2026
        new Shipment
        {
            Id = "CNT-2026-00230",
            SenderName = "Volvo AB",
            SenderCity = "Göteborg",
            RecipientName = "Scania Parts",
            RecipientCity = "Stockholm",
            Carrier = "DHL",
            Status = "transit",
            ETA = "8 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "6 mar, 08:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "6 mar, 14:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "6 mar, 18:00", Done = false, Active = true },
                new TrackingEvent { Event = "Out for delivery", Time = "", Done = false },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00229",
            SenderName = "Axfood",
            SenderCity = "Stockholm",
            RecipientName = "Butik Öst",
            RecipientCity = "Norrköping",
            Carrier = "Budbee",
            Status = "pending",
            ETA = "9 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "6 mar, 09:15", Done = true },
                new TrackingEvent { Event = "Awaiting pickup", Time = "", Done = false, Active = true },
                new TrackingEvent { Event = "In transit", Time = "", Done = false },
                new TrackingEvent { Event = "Out for delivery", Time = "", Done = false },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },

        // 5 mar 2026
        new Shipment
        {
            Id = "CNT-2026-00227",
            SenderName = "Ericsson AB",
            SenderCity = "Stockholm",
            RecipientName = "Tech Park",
            RecipientCity = "Linköping",
            Carrier = "PostNord",
            Status = "transit",
            ETA = "7 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "5 mar, 10:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "5 mar, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "6 mar, 08:00", Done = false, Active = true },
                new TrackingEvent { Event = "Out for delivery", Time = "", Done = false },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00226",
            SenderName = "H&M Logistik",
            SenderCity = "Stockholm",
            RecipientName = "Butik Väst",
            RecipientCity = "Göteborg",
            Carrier = "Bring",
            Status = "delayed",
            ETA = "5 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "5 mar, 08:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "5 mar, 15:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "5 mar, 20:00", Done = true },
                new TrackingEvent { Event = "Delayed – weather", Time = "6 mar, 06:00", Done = false, Active = true },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00225",
            SenderName = "Kappahl",
            SenderCity = "Mölndal",
            RecipientName = "Butik Nord",
            RecipientCity = "Umeå",
            Carrier = "PostNord",
            Status = "pending",
            ETA = "9 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "5 mar, 11:30", Done = true },
                new TrackingEvent { Event = "Awaiting pickup", Time = "", Done = false, Active = true },
                new TrackingEvent { Event = "In transit", Time = "", Done = false },
                new TrackingEvent { Event = "Out for delivery", Time = "", Done = false },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },

        // 4 mar 2026
        new Shipment
        {
            Id = "CNT-2026-00223",
            SenderName = "Spotify AB",
            SenderCity = "Stockholm",
            RecipientName = "Kontor Väst",
            RecipientCity = "Göteborg",
            Carrier = "Bring",
            Status = "delayed",
            ETA = "5 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "4 mar, 09:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "4 mar, 15:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "5 mar, 07:00", Done = true },
                new TrackingEvent { Event = "Delayed – sorting error", Time = "5 mar, 14:00", Done = false, Active = true },
                new TrackingEvent { Event = "Delivered", Time = "", Done = false }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00222",
            SenderName = "IKEA Sverige",
            SenderCity = "Älmhult",
            RecipientName = "Privatkund",
            RecipientCity = "Malmö",
            Carrier = "PostNord",
            Status = "delivered",
            ETA = "5 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "4 mar, 10:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "4 mar, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "5 mar, 07:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "5 mar, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "5 mar, 13:47", Done = true }
            }
        },

        // 3 mar 2026
        new Shipment
        {
            Id = "CNT-2026-00220",
            SenderName = "Sandvik AB",
            SenderCity = "Sandviken",
            RecipientName = "Atlas Copco",
            RecipientCity = "Nacka",
            Carrier = "DHL",
            Status = "delivered",
            ETA = "4 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "3 mar, 08:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "3 mar, 14:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "3 mar, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "4 mar, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "4 mar, 13:10", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00219",
            SenderName = "Systembolaget",
            SenderCity = "Stockholm",
            RecipientName = "Butik Syd",
            RecipientCity = "Helsingborg",
            Carrier = "Budbee",
            Status = "delivered",
            ETA = "4 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "3 mar, 11:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "3 mar, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "3 mar, 21:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "4 mar, 10:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "4 mar, 15:22", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00218",
            SenderName = "Autoliv AB",
            SenderCity = "Vårgårda",
            RecipientName = "Volvo Cars",
            RecipientCity = "Göteborg",
            Carrier = "DHL",
            Status = "delivered",
            ETA = "4 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "3 mar, 14:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "3 mar, 17:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "4 mar, 07:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "4 mar, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "4 mar, 11:45", Done = true }
            }
        },

        // 2 mar 2026
        new Shipment
        {
            Id = "CNT-2026-00216",
            SenderName = "SKF Sverige",
            SenderCity = "Göteborg",
            RecipientName = "Verkstad AB",
            RecipientCity = "Borås",
            Carrier = "Bring",
            Status = "delivered",
            ETA = "3 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "2 mar, 11:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "2 mar, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "2 mar, 21:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "3 mar, 08:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "3 mar, 12:15", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00215",
            SenderName = "Alfa Laval",
            SenderCity = "Lund",
            RecipientName = "Industri Nord",
            RecipientCity = "Sundsvall",
            Carrier = "PostNord",
            Status = "delivered",
            ETA = "3 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "2 mar, 09:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "2 mar, 15:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "2 mar, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "3 mar, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "3 mar, 14:30", Done = true }
            }
        },

        // 28 feb 2026
        new Shipment
        {
            Id = "CNT-2026-00212",
            SenderName = "Electrolux",
            SenderCity = "Stockholm",
            RecipientName = "MediaMarkt",
            RecipientCity = "Uppsala",
            Carrier = "DHL",
            Status = "delivered",
            ETA = "1 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "28 feb, 10:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "28 feb, 15:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "28 feb, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "1 mar, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "1 mar, 13:20", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00211",
            SenderName = "Husqvarna AB",
            SenderCity = "Huskvarna",
            RecipientName = "Trädgård AB",
            RecipientCity = "Västerås",
            Carrier = "Bring",
            Status = "delivered",
            ETA = "1 mar 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "28 feb, 11:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "28 feb, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "28 feb, 21:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "1 mar, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "1 mar, 15:00", Done = true }
            }
        },

        // 25 feb 2026
        new Shipment
        {
            Id = "CNT-2026-00208",
            SenderName = "Scania AB",
            SenderCity = "Södertälje",
            RecipientName = "Motor AB",
            RecipientCity = "Örebro",
            Carrier = "DHL",
            Status = "delivered",
            ETA = "26 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "25 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "25 feb, 14:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "25 feb, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "26 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "26 feb, 12:40", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00207",
            SenderName = "AstraZeneca",
            SenderCity = "Göteborg",
            RecipientName = "Pharma Nord",
            RecipientCity = "Stockholm",
            Carrier = "DHL",
            Status = "delivered",
            ETA = "26 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "25 feb, 11:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "25 feb, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "25 feb, 21:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "26 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "26 feb, 14:00", Done = true }
            }
        },

        // 22 feb 2026
        new Shipment
        {
            Id = "CNT-2026-00204",
            SenderName = "ABB Sverige",
            SenderCity = "Västerås",
            RecipientName = "Industri AB",
            RecipientCity = "Karlstad",
            Carrier = "Bring",
            Status = "delivered",
            ETA = "23 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "22 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "22 feb, 15:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "22 feb, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "23 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "23 feb, 13:00", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00203",
            SenderName = "Boliden AB",
            SenderCity = "Stockholm",
            RecipientName = "Gruv AB",
            RecipientCity = "Skellefteå",
            Carrier = "PostNord",
            Status = "delivered",
            ETA = "24 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "22 feb, 10:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "22 feb, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "23 feb, 07:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "24 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "24 feb, 15:30", Done = true }
            }
        },

        // 19 feb 2026
        new Shipment
        {
            Id = "CNT-2026-00200",
            SenderName = "Klarna AB",
            SenderCity = "Stockholm",
            RecipientName = "Fintech Väst",
            RecipientCity = "Göteborg",
            Carrier = "Budbee",
            Status = "delivered",
            ETA = "20 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "19 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "19 feb, 14:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "19 feb, 19:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "20 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "20 feb, 12:00", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00199",
            SenderName = "Telia AB",
            SenderCity = "Stockholm",
            RecipientName = "Telecom Syd",
            RecipientCity = "Malmö",
            Carrier = "DHL",
            Status = "delivered",
            ETA = "20 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "19 feb, 11:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "19 feb, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "19 feb, 21:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "20 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "20 feb, 14:20", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00198",
            SenderName = "Ikano AB",
            SenderCity = "Malmö",
            RecipientName = "Retail Nord",
            RecipientCity = "Luleå",
            Carrier = "PostNord",
            Status = "delivered",
            ETA = "21 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "19 feb, 13:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "19 feb, 17:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "20 feb, 07:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "21 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "21 feb, 16:00", Done = true }
            }
        },

        // 15 feb 2026
        new Shipment
        {
            Id = "CNT-2026-00195",
            SenderName = "Coor AB",
            SenderCity = "Stockholm",
            RecipientName = "Facility Väst",
            RecipientCity = "Göteborg",
            Carrier = "Bring",
            Status = "delivered",
            ETA = "16 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "15 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "15 feb, 14:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "15 feb, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "16 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "16 feb, 13:00", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00194",
            SenderName = "Nibe AB",
            SenderCity = "Markaryd",
            RecipientName = "Värme AB",
            RecipientCity = "Sundsvall",
            Carrier = "PostNord",
            Status = "delivered",
            ETA = "17 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "15 feb, 10:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "15 feb, 15:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "16 feb, 07:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "17 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "17 feb, 15:30", Done = true }
            }
        },

        // 12 feb 2026
        new Shipment
        {
            Id = "CNT-2026-00191",
            SenderName = "Lindab AB",
            SenderCity = "Grevie",
            RecipientName = "Bygg AB",
            RecipientCity = "Stockholm",
            Carrier = "DHL",
            Status = "delivered",
            ETA = "13 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "12 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "12 feb, 14:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "12 feb, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "13 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "13 feb, 12:30", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00190",
            SenderName = "Trelleborg AB",
            SenderCity = "Trelleborg",
            RecipientName = "Gummi Nord",
            RecipientCity = "Örnsköldsvik",
            Carrier = "Bring",
            Status = "delivered",
            ETA = "14 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "12 feb, 11:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "12 feb, 16:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "13 feb, 07:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "14 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "14 feb, 16:00", Done = true }
            }
        },

        // 8 feb 2026
        new Shipment
        {
            Id = "CNT-2026-00187",
            SenderName = "Getinge AB",
            SenderCity = "Göteborg",
            RecipientName = "Medtech AB",
            RecipientCity = "Uppsala",
            Carrier = "DHL",
            Status = "delivered",
            ETA = "9 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "8 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "8 feb, 14:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "8 feb, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "9 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "9 feb, 13:00", Done = true }
            }
        },
        new Shipment
        {
            Id = "CNT-2026-00186",
            SenderName = "Hexpol AB",
            SenderCity = "Malmö",
            RecipientName = "Polymer AB",
            RecipientCity = "Göteborg",
            Carrier = "Budbee",
            Status = "delivered",
            ETA = "9 feb 2026",
            History = new List<TrackingEvent>
            {
                new TrackingEvent { Event = "Order placed", Time = "8 feb, 10:00", Done = true },
                new TrackingEvent { Event = "Picked up by carrier", Time = "8 feb, 15:00", Done = true },
                new TrackingEvent { Event = "In transit", Time = "8 feb, 20:00", Done = true },
                new TrackingEvent { Event = "Out for delivery", Time = "9 feb, 09:00", Done = true },
                new TrackingEvent { Event = "Delivered", Time = "9 feb, 14:00", Done = true }
            }
        },
    };
}