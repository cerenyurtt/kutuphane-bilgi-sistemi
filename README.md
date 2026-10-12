# KütüphaneBS – Kütüphane Yönetim Sistemi

Kitap, yazar, tür, üye ve ödünç işlemlerini yönetmek için geliştirilen bir Windows masaüstü uygulaması. Proje **geliştirme aşamasındadır**: veri modeli tamamlandı, arayüz ve servis katmanı adım adım genişletiliyor.

## Teknolojiler

- C# / .NET 8
- Windows Forms (arayüz)
- Entity Framework Core 8 (Code First, Migrations)
- Microsoft SQL Server

## Proje Yapısı

| Proje | Açıklama |
|---|---|
| `KutuphaneBS.Service` | Veri modelleri (`Model`), veritabanı bağlamı (`KutuphaneDB`), servis sınıfları (`Core`) ve migration dosyaları |
| `KutuphaneBS.UI` | Windows Forms arayüzü |

Katmanlar ayrıdır: arayüz, veritabanına doğrudan erişmez; `Service` projesindeki servisleri kullanır.

## Veri Modeli

- **Kitap** – ad, ISBN, sayfa sayısı, durum; bir **Tür** ve bir **Yazar**'a bağlı
- **Yazar**, **Tür** – bire çok ilişkiyle kitaplara bağlı
- **Üye** – ad soyad, kimlik no, e-posta, iletişim, cinsiyet
- **OduncIslem** – bir üyenin ödünç alma kaydı (alış tarihi, durum)
- **OduncIslemDetay** – ödünç işlemindeki kitaplar ve teslim tarihi (bir işlemde birden fazla kitap olabilir)

## Mevcut Durum

- [x] Veritabanı modeli ve migration'lar
- [x] Tür için ekleme, listeleme, güncelleme ve silme (servis + arayüz)
- [ ] Kitap, yazar ve üye ekranları
- [ ] Ödünç alma ve teslim etme işlemleri
- [ ] Girdi doğrulama ve hata mesajları

## Kurulum ve Çalıştırma

**Gereksinimler:** Visual Studio 2022, .NET 8 SDK, SQL Server (veya SQL Server Express)

1. Depoyu klonlayın:
   ```
   git clone https://github.com/<kullanici-adiniz>/KutuphaneBS.git
   ```
2. `KutuphaneBS.sln` dosyasını Visual Studio ile açın.
3. `KutuphaneBS.Service/Model/KutuphaneDB.cs` içindeki bağlantı dizesinde `Server=` kısmını kendi SQL Server adınızla değiştirin (örn. `localhost\SQLEXPRESS`).
4. Package Manager Console'da `KutuphaneBS.Service` projesini seçip veritabanını oluşturun:
   ```
   Update-Database
   ```
5. `KutuphaneBS.UI` projesini başlangıç projesi yapıp çalıştırın (F5).

## Geliştirme Planı

- Diğer varlıklar için servis ve arayüz eklemek
- Bağlantı dizesini koddan çıkarıp yapılandırma dosyasına taşımak
- Silme işlemlerinde ilişkili kayıt kontrolü eklemek
