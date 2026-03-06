# ShipTrack API

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![REST API](https://img.shields.io/badge/REST-API-FF6C37?style=for-the-badge&logo=postman&logoColor=white)
![Render](https://img.shields.io/badge/Deployed%20on-Render-46E3B7?style=for-the-badge&logo=render&logoColor=white)

Backend API for **ShipTrack** — a shipment tracking system designed to simulate how logistics platforms manage shipment flows, carriers, and delivery statuses.

Inspired by companies like Centiro that power global delivery networks, this project simulates how shipments, statuses, and carriers can be structured and visualized through an operational dashboard.

> ⚠️ **Note:** The backend is hosted on Render's free tier and may take **30–60 seconds to spin up** on the first request after inactivity. Please be patient – subsequent requests will be fast.

---

## Project Purpose

This project was built to explore the structure of logistics platforms and shipment tracking systems.

It focuses on modeling shipment data, tracking events, and building API endpoints that support operational dashboards similar to those used in logistics and delivery platforms.

---

## 🔗 Links

- **Live API:** [https://shiptrack-api.onrender.com](https://shiptrack-api.onrender.com)
- **Frontend repo:** [shiptrack-client](https://github.com/Megjafari/shiptrack-client)
- **Live demo:** [https://shiptrack.meghdadjafari.dev](https://shiptrack.meghdadjafari.dev)

---

## Features

- `GET /api/shipments` – Fetch all shipments with optional filtering by status and search query
- `GET /api/shipments/{id}` – Fetch a single shipment with full tracking history
- `POST /api/shipments` – Create a new shipment with auto-generated tracking ID
- `GET /api/shipments/stats` – Fetch shipment volume per day for the last 30 days
  
-  Shipment tracking event history
- Realistic logistics domain modeling
- RESTful API design

---

## Tech Stack

| Layer | Technology |
|-------|-----------|
| Framework | ASP.NET Core 10 Web API |
| Language | C# |
| Architecture | Controller-based REST API |
| Data | In-memory mock data (27 realistic shipments) |
| CORS | Configured for frontend origin |
| Deploy | Render |

---

## Project Structure

```
ShipTrackApi/
├── Controllers/
│   └── ShipmentsController.cs   # API endpoints
├── Models/
│   ├── Shipment.cs              # Shipment and TrackingEvent models
│   └── ShipmentData.cs          # Mock data (27 shipments)
├── Program.cs                   # App setup, CORS, routing
└── ShipTrackApi.csproj
```

---

## API Reference

### GET /api/shipments

Returns all shipments. Supports optional query parameters:

| Parameter | Type | Description |
|-----------|------|-------------|
| `status` | string | Filter by status: `transit`, `delivered`, `delayed`, `pending` |
| `search` | string | Search by tracking ID or city name |

**Example:**
```
GET /api/shipments?status=transit&search=Stockholm
```

**Response:**
```json
[
  {
    "id": "CNT-2026-00230",
    "senderName": "Volvo AB",
    "senderCity": "Göteborg",
    "recipientName": "Scania Parts",
    "recipientCity": "Stockholm",
    "carrier": "DHL",
    "status": "transit",
    "eta": "8 mar 2026",
    "history": [...]
  }
]
```

---

### GET /api/shipments/{id}

Returns a single shipment including full tracking event history.

**Example:**
```
GET /api/shipments/CNT-2026-00230
```

---

### POST /api/shipments

Creates a new shipment. Auto-generates a tracking ID with status `pending`.

**Request body:**
```json
{
  "senderName": "Företag AB",
  "senderCity": "Stockholm",
  "recipientName": "Kund AB",
  "recipientCity": "Göteborg",
  "carrier": "PostNord",
  "eta": "2026-03-15"
}
```

**Response:** `201 Created` with the new shipment object.

---

### GET /api/shipments/stats

Returns shipment count per day for the last 30 days.

**Response:**
```json
[
  { "date": "05 Feb", "count": 0 },
  { "date": "08 Feb", "count": 2 },
  ...
]
```

---

## Running Locally

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Steps

```bash
# Clone the repo
git clone https://github.com/Megjafari/shiptrack-api.git
cd shiptrack-api

# Run the API
dotnet run
```

The API will be available at `http://localhost:5141`.

---

Built by [Meghdad jafari](https://meghdadjafari.dev)
