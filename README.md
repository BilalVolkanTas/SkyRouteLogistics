# ✈️ SkyRoute Logistics

**Havayolu Kargo ve Uçuş Yönetim Sistemi**

SkyRoute Logistics, havayolu uçuşlarının ve kargo konteynerlerinin merkezi bir yönetim arayüzü üzerinden yönetilmesini sağlayan web tabanlı bir lojistik uygulamasıdır.

Proje; **ASP.NET Core MVC, REST API, Entity Framework Core ve PostgreSQL** teknolojileri kullanılarak geliştirilmiştir.

## 🚀 Özellikler

### ✈️ Uçuş Yönetimi

* Uçuş kayıtları oluşturma
* Uçuş bilgilerini görüntüleme
* Mevcut uçuş kayıtlarını düzenleme
* Uçuş kayıtlarını silme
* Uçuş verilerine REST API üzerinden erişme

### 📦 Kargo Konteyner Yönetimi

* Kargo konteyneri oluşturma
* Kargo konteynerlerini uçuşlara atama
* Konteyner bilgilerini görüntüleme
* Kargo kayıtlarını düzenleme
* Kargo kayıtlarını silme

### 🔌 REST API

Projede uçuş verilerini JSON formatında sunan bir REST API bulunmaktadır.

```http
GET /api/flights
```

Bu endpoint, mevcut uçuş kayıtlarını JSON formatında döndürür ve frontend uygulamaları veya diğer servisler tarafından kullanılabilir.

## 🏗️ Mimari

Uygulama, **ASP.NET Core MVC** tabanlı katmanlı bir proje yapısı kullanmaktadır.

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

Projede kullanılan temel yaklaşımlar:

* ASP.NET Core MVC
* REST API
* Entity Framework Core
* Code First
* Dependency Injection
* PostgreSQL

## 🛠️ Kullanılan Teknolojiler

### Backend

* C#
* ASP.NET Core
* ASP.NET Core MVC
* ASP.NET Core Web API

### Veritabanı

* PostgreSQL
* Entity Framework Core
* Entity Framework Core Migrations
* Npgsql

### Geliştirme Araçları

* Visual Studio
* .NET CLI
* Git
* GitHub

## 🗄️ Veritabanı

Projenin ana veritabanı olarak **PostgreSQL** kullanılmaktadır.

Entity Framework Core, ORM olarak kullanılmakta ve veritabanı şeması **Code First Migration** yaklaşımıyla yönetilmektedir.

### Temel Modeller

* `Flight`
* `CargoContainer`

Uçuş ve kargo konteynerleri arasındaki ilişki sayesinde kargo kayıtları belirli uçuşlarla ilişkilendirilebilmektedir.

## 🔌 API

### Uçuşları Getirme

```http
GET /api/flights
```

Uygulamadaki mevcut uçuş kayıtlarını JSON formatında döndürür.

Örnek:

```json
[
  {
    "id": 1,
    "flightNumber": "TK123",
    "destination": "Istanbul"
  }
]
```

> Dönen alanlar mevcut `Flight` modeline göre değişebilir.

## ⚙️ Kurulum

### 1. Repository'yi klonlayın

```bash
git clone https://github.com/BilalVolkanTas/SkyRouteLogistics.git
cd SkyRouteLogistics
```

### 2. Veritabanı bağlantısını yapılandırın

`appsettings.json` içerisindeki PostgreSQL bağlantı bilgisini kendi ortamınıza göre düzenleyin.

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=YOUR_HOST;Database=YOUR_DATABASE;Username=YOUR_USERNAME;Password=YOUR_PASSWORD;Port=5432;SSL Mode=Require;Trust Server Certificate=true"
}
```

> Gerçek veritabanı şifrelerini repository içerisinde paylaşmayın.

### 3. Bağımlılıkları yükleyin

```bash
dotnet restore
```

### 4. Migration'ları uygulayın

```bash
dotnet ef database update
```

### 5. Uygulamayı çalıştırın

```bash
dotnet run
```

Uygulama, .NET CLI tarafından belirtilen adres üzerinden çalışacaktır.

## 📁 Proje Yapısı

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

## 🎯 Proje ile Kazanılan Deneyimler

Bu proje geliştirilirken aşağıdaki konularda pratik deneyim kazanılmıştır:

* ASP.NET Core MVC geliştirme
* REST API geliştirme
* Entity Framework Core
* Code First veritabanı tasarımı
* Entity ilişkileri
* Database Migration yönetimi
* PostgreSQL entegrasyonu
* Dependency Injection
* CRUD işlemleri
* Git ve GitHub kullanımı

## 🔮 Gelecekte Yapılabilecek Geliştirmeler

Projeye ilerleyen aşamalarda aşağıdaki özellikler eklenebilir:

* Authentication ve Authorization
* Rol tabanlı yetkilendirme
* Gelişmiş uçuş filtreleme
* Pagination ve sorting
* DTO tabanlı API yapısı
* Gelişmiş validation
* Merkezi hata yönetimi
* Otomatik testler
* Docker containerization

## 👨‍💻 Geliştirici

**Bilal Volkan Taş**

Computer Engineering Student
İskenderun Teknik Üniversitesi

[GitHub](https://github.com/BilalVolkanTas)
