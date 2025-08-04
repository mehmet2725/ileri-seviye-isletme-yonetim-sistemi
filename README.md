# İleri Seviye İşletme Yönetim Sistemi

Bu proje, orta ve ileri düzey işletmelerin yönetim süreçlerini kolaylaştırmak amacıyla geliştirilmiş kapsamlı bir masaüstü yazılım sistemidir. Kullanıcı, çalışan ve yönetici seviyelerinde farklı yetkilendirmelerle işletmenin stok, sipariş, müşteri, çalışan ve geri bildirim yönetimi yapılabilir.

## 📌 Proje Özellikleri

- Rol tabanlı kullanıcı sistemi (Yönetici, Çalışan, Müşteri)
- Sipariş oluşturma, düzenleme, görüntüleme
- Müşteri borç/alacak ve iletişim yönetimi
- Stok bilgileri görüntüleme, ekleme ve düzenleme
- Çalışan vardiya bilgileri ve yetki seviyesi yönetimi
- Geri bildirim toplama sistemi
- Log ve işlem kayıtları (trigger destekli)

## 🧱 Kullanılan Teknolojiler

- **Dil:** C# (.NET Framework)
- **Arayüz:** WinForms
- **Veritabanı:** MySQL
- **Yapı:** Çok tablolı ilişkisel veritabanı (Foreign Key + Trigger)

## 🗃️ Veritabanı Tabloları

- `kullanicilar`: Genel kullanıcı bilgileri
- `calisanlar`: Vardiya, görev ve yetki verileri
- `musteriler`: Borç/alacak ve iletişim bilgileri
- `urunler`: Ürün adı, miktar ve fiyat bilgileri
- `siparisler`: Sipariş ana kayıtları
- `siparis_urunler`: Siparişteki ürün detayları
- `feedback`: Geri bildirim kayıtları
- `loglar`: İşlem logları (otomatik kayıtlar)

## 👥 Rol Bazlı Giriş Sistemi

- **Yönetici:** Tüm modüllere erişim ve yönetim
- **Çalışan:** Yetki seviyesine göre sınırlı modüller
- **Müşteri:** Kendi bilgilerini ve siparişlerini yönetebilir

## 🔐 Güvenlik ve Loglama

- Tüm veritabanı işlemleri `loglar` tablosuna kayıt edilir.
- Trigger’lar ile otomatik log kayıt sistemi (INSERT, UPDATE, DELETE)
- Parametreli SQL kullanımı (SQL Injection koruması)

## ⚙️ Kurulum

1. MySQL'de `bitirme_projesi` adında veritabanı oluştur.
2. Tabloları ve trigger’ları oluştur (SQL script dosyasını çalıştır).
3. Visual Studio'da projeyi aç.
4. `app.config` içinde veritabanı bağlantı bilgilerini düzenle:

```xml
<connectionStrings>
  <add name="conn" connectionString="Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=seninsifren;" />
</connectionStrings>
```

5. Uygulamayı çalıştır.

## 👤 Geliştirici

**Mehmet Sönmez**  
Amasya Üniversitesi - Bilgisayar Programcılığı  
Ocak 2025  
Danışman: Öğr. Gör. Dr. Sabri Serkan TAN
