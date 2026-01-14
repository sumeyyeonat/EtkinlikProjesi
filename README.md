# EtkinlikProjesi

Bu proje, ASP.NET Core MVC kullanarak geliştirilmiş bir etkinlik yönetim uygulamasıdır. Kullanıcılar etkinlikleri listeleyebilir, yeni etkinlik ekleyebilir, düzenleyebilir ve silebilir.

## Özellikler

- Etkinlik listesi görüntüleme
- Yeni etkinlik oluşturma
- Mevcut etkinlikleri düzenleme
- Etkinlik detaylarını görüntüleme
- Etkinlik silme

## Gereksinimler

- .NET 10.0 SDK
- SQLite (Entity Framework Core ile birlikte gelir)

## Kurulum

1. Projeyi klonlayın:
   ```
   git clone https://github.com/kullanici-adi/EtkinlikProjesi.git
   cd EtkinlikProjesi
   ```

2. Bağımlılıkları yükleyin:
   ```
   dotnet restore
   ```

3. Veritabanını oluşturun ve migrasyonları uygulayın:
   ```
   dotnet ef database update
   ```

## Çalıştırma

Uygulamayı başlatmak için:
```
dotnet run
```

Tarayıcınızda `https://localhost:5001` adresine gidin (veya launchSettings.json'da belirtilen port).

## Proje Yapısı

- **Controllers/**: MVC controller'ları
- **Models/**: Veri modelleri
- **Views/**: Razor view'ları
- **Data/**: Veritabanı bağlamı ve migrasyonlar
- **wwwroot/**: Statik dosyalar (CSS, JS, Bootstrap)

## Teknolojiler

- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Bootstrap
- jQuery

## Katkıda Bulunma

1. Bu repository'yi fork edin.
2. Yeni bir branch oluşturun (`git checkout -b feature/yeni-ozellik`).
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`).
4. Branch'inizi push edin (`git push origin feature/yeni-ozellik`).
5. Pull Request oluşturun.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır.