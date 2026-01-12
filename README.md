# ⚙️ Backend Core & API Architecture Lab

Bu proje, .NET Core üzerinde kurumsal mimariye uygun, sürdürülebilir ve geliştirilebilir bir **RESTful API Altyapısı** kurmak amacıyla geliştirilmiş bir Ar-Ge çalışmasıdır.

Proje; veritabanı tasarımı, ORM (Object Relational Mapping) kullanımı ve asenkron programlama prensipleri üzerine odaklanmıştır.

## 🎯 Projenin Odak Noktası
Sadece çalışan bir kod yazmak değil; modern backend standartlarına (Async/Await, Dependency Injection) uygun bir kod tabanı oluşturmak hedeflenmiştir.

## 🛠 Teknik Altyapı

* **Platform:** .NET Core / ASP.NET Core
* **Dil:** C#
* **Veritabanı:** MS SQL Server
* **ORM:** Entity Framework Core
* **Mimari:** MVC / API Controller Pattern

## 🔬 Geliştirilen Modüller

### 1. API Kontrolcüleri (Controllers)
`BlogController` örneğinde olduğu gibi, dış dünyaya veri sunan HTTP protokolüne uygun (GET, POST) uç noktalar geliştirilmiştir.

### 2. Asenkron Programlama (Async/Await)
Veritabanı işlemlerinde `SaveChangesAsync` ve `FindAsync` gibi asenkron metotlar kullanılarak, sunucunun ana iş parçacığını (Main Thread) bloklamadan yüksek performansla çalışması sağlanmıştır.

### 3. Dependency Injection (Bağımlılık Enjeksiyonu)
Veritabanı bağlamı (`AppDbContext`), kontrolcülerin yapıcı metotlarına (Constructor) enjekte edilerek gevşek bağlı (Loosely Coupled) bir yapı kurulmuştur.

## 📝 Notlar
Bu repo, backend teknolojilerindeki yetkinliğimi artırmak ve yeni mimari desenleri test etmek için kullandığım bir **Laboratuvar (Lab)** ortamıdır.

---
*Developed by Volkan Ekici*