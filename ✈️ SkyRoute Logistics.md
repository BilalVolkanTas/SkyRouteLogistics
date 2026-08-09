# ✈️ SkyRoute Logistics

**Airline Cargo and Flight Management System**

SkyRoute Logistics is a web-based logistics management application designed to manage airline flights and cargo containers through a centralized management interface.

The project was developed using **ASP.NET Core MVC, REST API, Entity Framework Core, and PostgreSQL**.

## 🚀 Features

### ✈️ Flight Management

- Create flight records
- View flight information
- Edit existing flight records
- Delete flight records
- Access flight data through a REST API

### 📦 Cargo Container Management

- Create cargo container records
- Assign cargo containers to flights
- View container information
- Edit cargo records
- Delete cargo records

### 🔌 REST API

The project includes a REST API for retrieving flight data.

```http
GET /api/flights
```

The endpoint returns flight records in JSON format and can be consumed by frontend applications or other services.

## 🏗️ Architecture

The application follows an **ASP.NET Core MVC** based layered project structure.

```text
SkyRouteLogistics
│
├── Controllers
│   ├── FlightsController
│   ├── CargoContainersController
│   └── FlightsApiController
│
├── Models
│   ├── Flight
│   ├── CargoContainer
│   └── AppDbContext
│
├── Views
│   ├── Flights
│   ├── CargoContainers
│   └── Home
│
├── Migrations
│
└── Program.cs
```

The project uses:

- ASP.NET Core MVC
- REST API
- Entity Framework Core
- Code First approach
- Dependency Injection
- PostgreSQL

## 🛠️ Technologies

### Backend

- C#
- ASP.NET Core
- ASP.NET Core MVC
- ASP.NET Core Web API

### Database

- PostgreSQL
- Entity Framework Core
- Entity Framework Core Migrations
- Npgsql

### Development Tools

- Visual Studio
- .NET CLI
- Git
- GitHub

## 🗄️ Database

**PostgreSQL** is used as the primary database.

Entity Framework Core is used as the ORM, while the database schema is managed through the **Code First Migration** approach.

### Main Models

- `Flight`
- `CargoContainer`

The relationship between flights and cargo containers allows cargo records to be associated with specific flights.

## 🔌 API

### Get Flights

```http
GET /api/flights
```

Returns the available flight records in JSON format.

Example:

```json
[
  {
    "id": 1,
    "flightNumber": "TK123",
    "destination": "Istanbul"
  }
]
```

> The returned fields may vary depending on the current `Flight` model.

## ⚙️ Installation

### 1. Clone the repository

```bash
git clone https://github.com/BilalVolkanTas/SkyRouteLogistics.git
cd SkyRouteLogistics
```

### 2. Configure the database

Open `appsettings.json` and configure the PostgreSQL connection string according to your environment.

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=YOUR_HOST;Database=YOUR_DATABASE;Username=YOUR_USERNAME;Password=YOUR_PASSWORD;Port=5432;SSL Mode=Require;Trust Server Certificate=true"
}
```

> Never commit real database credentials to a public repository.

### 3. Restore dependencies

```bash
dotnet restore
```

### 4. Apply database migrations

```bash
dotnet ef database update
```

### 5. Run the application

```bash
dotnet run
```

The application will run at the URL provided by the .NET CLI.

## 📁 Project Structure

```text
SkyRouteLogistics/
│
├── Controllers/
│   ├── CargoContainersController.cs
│   ├── FlightsApiController.cs
│   ├── FlightsController.cs
│   └── HomeController.cs
│
├── Models/
│   ├── AppDbContext.cs
│   ├── CargoContainer.cs
│   ├── Flight.cs
│   └── ErrorViewModel.cs
│
├── Migrations/
│
├── Views/
│   ├── CargoContainers/
│   ├── Flights/
│   ├── Home/
│   └── Shared/
│
├── Program.cs
├── appsettings.json
└── SkyRouteLogistics.csproj
```

## 🎯 What I Practiced

This project provided practical experience with:

- ASP.NET Core MVC development
- REST API development
- Entity Framework Core
- Code First database design
- Entity relationships
- Database migrations
- PostgreSQL integration
- Dependency Injection
- CRUD operations
- Git and GitHub workflow

## 🔮 Future Improvements

Possible future improvements include:

- Authentication and Authorization
- Role-based access control
- Advanced flight filtering
- Pagination and sorting
- DTO-based API responses
- Improved validation
- Centralized error handling
- Automated testing
- Docker containerization

## 👨‍💻 Developer

**Bilal Volkan Taş**

Computer Engineering Student  
İskenderun Technical University

[GitHub](https://github.com/BilalVolkanTas)