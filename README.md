# 🚀 Kişisel Portfolyo Projesi – Bootcamp Case #1

Bu proje, **ASP.NET Core MVC** kullanılarak geliştirilmiş **tamamen dinamik ve yönetilebilir bir kişisel portfolyo web uygulamasıdır**.  
Bootcamp kapsamında **M&Y Yazılım Eğitim Akademi** tarafından verilen .NET Full Stack eğitiminin 1. Case çalışması olarak tasarlanmıştır.  

Projenin temel amacı, bir yazılım geliştiricinin veya profesyonelin kendisini tanıtacağı, projelerini, yeteneklerini ve deneyimlerini sergileyebileceği modern bir portfolyo sitesi oluşturmaktır.  

Projede AI ve tasarım araçları kullanılarak admin panel ve ön yüz arayüzü optimize edilmiş, modern ve kullanıcı dostu bir deneyim sunulmuştur.

---

## ✨ Öne Çıkan Özellikler

### 🔹 Dinamik Kullanıcı Arayüzü
- Öne çıkan profil alanı: Ad-Soyad, profil fotoğrafı ve değişen yazılar (örn. "I'm a Photography lover")  
- Sosyal medya ikonları ve linkleri veri tabanından yönetiliyor  
- Hakkımda, Yetenekler, Hizmetler ve Deneyimler tamamen dinamik  
- CV indirme özelliği ile kullanıcı dosyayı tarayıcı üzerinden alabilir  

### 🔹 Admin Panel
- **Tam CRUD desteği:** Hakkımda, Deneyimler, Eğitim, Yetenekler, Projeler, Referanslar ve Sosyal Medya linkleri  
- Dashboard: Anlık istatistik kartları ve özet bilgiler  
- Mesaj yönetim sistemi: Gelen mesajları okuma, okundu işaretleme ve silme  
- Bildirim sistemi: Okunmamış mesajlar ve toplam proje sayısı  
- Modern UI/UX: Tailwind CSS ile tasarlanmış gradient’lı ve dark mode destekli arayüz  
- AI destekli tasarım ve templateler kullanılarak admin paneli optimize edilmiştir  

### 🔹 Projeler & Kategoriler
- Gerçekleştirilen projeler ekran görüntüleriyle listelenir  
- Kategori bazlı filtreleme opsiyonu  
- Dinamik olarak veri tabanından çekilen içerik  

### 🔹 İletişim & Mesaj Formu
- Dinamik iletişim formu ile ziyaretçiler mesaj gönderebilir  
- Mesajlar admin panelde görüntülenebilir ve yönetilebilir  

---

## 🛠️ Kullanılan Teknolojiler

| Katman | Teknoloji / Araç |
|--------|----------------|
| Backend | C#, ASP.NET Core MVC, Entity Framework Core (Code First) |
| Frontend | Razor Views, Tailwind CSS, Material Icons |
| Veritabanı | MSSQL Server |
| Tasarım | AI / Cloud Tasarım Araçları ile UI/UX optimize edilmiş |
| Mimari | MVC Pattern, Repository Pattern |
| Versiyon Kontrol | Git & GitHub |

---

## 📂 Proje Yapısı
Case1ResumeProject/
├─ wwwroot/ — CSS, JS, görseller, CV dosyaları
├─ Controllers/ — MVC Controller’ları
├─ Models/ — Veri modelleri
├─ Views/ — Razor View dosyaları
├─ Case1ResumeProject.sln — Visual Studio çözüm dosyası
├─ .gitignore — Git ignore kuralları

---

### 🔧 Admin Panel Modülleri

| Modül | Özellikler |
|-------|-----------|
| Dashboard | İstatistik kartları, son projeler, mesaj özetleri |
| Hakkımda | Profil bilgileri CRUD |
| Mesajlar | Gelen mesajları listeleme, okundu işaretleme, silme |
| Deneyimler | İş deneyimleri CRUD |
| Eğitimler | Eğitim geçmişi CRUD |
| Yetenekler | Skill yönetimi CRUD |
| Projeler | Portfolio projeleri CRUD |
| Sosyal Medya | Sosyal medya linkleri CRUD |
| Referanslar | Referans yönetimi CRUD |

---

## 📊 Veri Modeli (Entities)

Projenin ana veri modelleri:

- **About** – Profil ve Hakkımda bilgileri  
- **Message** – İletişim formu mesajları (IsRead, SendDate)  
- **Experience** – İş deneyimleri  
- **Education** – Eğitim geçmişi  
- **Skill** – Yetenekler ve skill seviyeleri  
- **Portfolio** – Projeler  
- **SocialMedia** – Sosyal medya linkleri  
- **Testimonial** – Referanslar ve değerlendirmeler  

---

## 🎯 Öğrendiklerim ve Kazanımlar

- MVC mimarisi ve ASP.NET Core uygulama sürecini uygulamalı olarak öğrendim  
- CRUD işlemleri ile dinamik veri yönetimi gerçekleştirdim  
- Modern frontend tasarım teknikleri (Tailwind CSS) ile UI/UX pratiği yaptım  
- Admin panel ve kullanıcı arayüzü tasarımını AI destekli araçlarla optimize ettim  
- Git & GitHub ile proje versiyon kontrolü ve deployment pratiği kazandım  

---

## 🚀 Kurulum ve Çalıştırma

1. Repo klonlayın:  
   ```bash
   git clone https://github.com/sena-nur-ozdemir/portfolio-project-case1.git
2. Visual Studio ile açın (Case1ResumeProject.sln)
3. *appsettings.json* dosyasında MSSQL bağlantı ayarlarını yapın.
4. Package Manager Console’dan migrationları uygulayın:
     ```bash
    update-database
5. Projeyi çalıştırın (F5 veya Ctrl + F5)
6. Admin panel ve tüm dinamik içerikler çalışır hale gelir.

---

Bu proje, tamamen modern, dinamik ve AI destekli bir portfolyo web uygulaması örneğidir.
Hem teknik yeteneklerimi hem de UI/UX tasarım sürecini gösteren kapsamlı bir çalışmadır.

---

Bu proje, **M&Y Yazılım Eğitim Akademi Danışmanlık** tarafından sağlanan eğitim kapsamında geliştirilmiştir.
Değerli katkıları ve öğretileri için **Murat Yücedağ** hocama teşekkür ederim.
