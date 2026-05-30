# ✈️ SkyRoute Logistics - Havayolu Kargo Takip Sistemi

Bu proje, uluslararası bir havayolu kargo şirketinin slot ve konteyner yönetimini simüle eden, modern web teknolojileriyle geliştirilmiş **hibrit mimarili** bir lojistik yönetim panelidir.

## 🏗️ Kullanılan Teknolojiler & Mimari
Proje, hem monolitik hem de dağıtık mimari yaklaşımlarını bir arada barındırmaktadır:
* **Backend:** .NET Core 10.0 (Web API & MVC)
* **Frontend:** AngularJS (Micro-Frontend / Gömülü Bileşen yapısında)
* **ORM:** Entity Framework Core (Code-First Yaklaşımı)
* **Veri Tabanı:** Bulut PostgreSQL (Neon.tech / AWS Europe)

## 📂 Sistem Mimarisi ve Veri Akışı
1. **Yönetim Paneli (MVC):** Sistem yöneticileri `/Flights` ve `/CargoContainers` rotalarını kullanarak uçuş rotalarını planlar ve kargo konteynerlerini uçuşlara atar. Bu veriler anlık olarak buluttaki PostgreSQL'e yazılır.
2. **Canlı Takip Ekranı (API + Angular):** Havalimanı operasyon sorumluları ana sayfayı açtığında, Angular arka planda `.NET Web API` ucuna (`/api/flights`) asenkron HTTP istekleri atar. Gelen JSON verisi, sayfa hiç yenilenmeden (SPA mantığıyla) ekrandaki canlı tabloya yansıtılır.

## 🛠️ Yerel Kurulum ve Çalıştırma
Projeyi kendi bilgisayarınızda çalıştırmak için şu adımları sırayla uygulayın:

1. Projeyi bilgisayarınıza indirin veya GitHub üzerinden klonlayın.
2. `appsettings.json` dosyasını açarak PostgreSQL bağlantı dizenizi (Connection String) tanımlayın.
3. Terminali açın ve gerekli bağımlılıkları yüklemek için şu komutu çalıştırın:
```bash
   dotnet restore

4.Veri tabanı migration işlemlerini yerel veya bulut veri tabanınıza uygulamak için:

dotnet ef database update

5.Projeyi lokal sunucuda ayağa kaldırmak için:

dotnet run

6.Tarayıcınızdan terminalin size verdiği adrese (Örn: http://localhost:5089) gidin.