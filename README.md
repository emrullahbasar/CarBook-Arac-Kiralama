# 🚗 CarBook – ASP.NET Core 8.0 ve Onion Architecture ile Geliştirilen Araç Kiralama Sistemi

Bu proje, **ASP.NET Core 8.0** ve **Onion Architecture** yapısını temel alarak geliştirilmiş, uçtan uca çalışan bir **Araç Kiralama Sistemi** örneğidir.
Projenin geliştirilme sürecinde **Murat Yücedağ**’ın Udemy’deki *Asp.Net Core API 8.0 Onion Architecture ile BookCar Projesi* eğitiminden büyük ölçüde ilham aldım.
Yazılım mimarisine ve katmanlı yapıya dair bana kattıkları için kendisine içtenlikle teşekkür ederim.

Bu proje ile amacım, hem kurumsal standartlarda bir mimariyi deneyimlemek hem de **API, MVC ve veri katmanlarının nasıl birbiriyle entegre çalıştığını** gerçek bir senaryo üzerinden öğrenmekti.
Ortaya, kullanıcı (vitrin) tarafı ve yönetici paneli (admin) içeren, tam fonksiyonel bir **araç kiralama platformu** çıktı.

---

## 🧱 Mimari Yapı ve Katmanlar

Projede klasik katmanlı mimari yerine **Onion Architecture (Soğan Mimarisi)** uygulanarak bağımlılıklar merkeze doğru azaltılmıştır.
Katmanlar net biçimde birbirinden ayrılmış, sürdürülebilir ve test edilebilir bir yapı oluşturulmuştur:

### 1️⃣ Domain Layer (Varlık Katmanı)

* Projede kullanılan tüm **entity** sınıfları bu katmanda tanımlanmıştır.
* Veritabanı tablolarının iskeleti burada oluşturulmuştur.
* Katmanlar arası bağımlılığın minimumda tutulması hedeflenmiştir.

### 2️⃣ Application Layer (Uygulama Katmanı)

* **CQRS (Command Query Responsibility Segregation)** yapısına uygun olarak tüm komut ve sorgular burada toplanmıştır.
* **MediatR** kütüphanesi ile katmanlar arasında güçlü bir iletişim sağlanmıştır.
* **FluentValidation** kullanılarak model doğrulama süreçleri merkezi hale getirilmiştir.
* **JWT** tabanlı kimlik doğrulama ve yetkilendirme işlemleri uygulanmıştır.

### 3️⃣ Infrastructure Layer (Altyapı Katmanı)

* **Entity Framework Core** ile veri erişim işlemleri yürütülmüştür.
* **Repository Pattern** kullanılarak CRUD operasyonları soyutlanmış ve test edilebilir hale getirilmiştir.
* Güvenlik, token üretimi ve loglama işlemleri bu katmanda yer alır.

### 4️⃣ WebUI / Presentation Layer (Sunum Katmanı)

* Kullanıcı arayüzü **ASP.NET Core MVC** ile geliştirilmiştir.
* **Razor Pages**, **PartialView** ve **ViewComponent** yapılarıyla modüler ve dinamik ekranlar oluşturulmuştur.
* **Bootstrap 5**, **HTML5**, **CSS3** ve **JavaScript** ile modern bir görünüm kazandırılmıştır.

### 5️⃣ API Layer (Web API Katmanı)

* **RESTful servisler** geliştirilmiş, **Swagger** ile dokümantasyon sağlanmıştır.
* Uygulamanın WebUI katmanı API üzerinden veri tüketmektedir.
* **SignalR** entegrasyonu ile gerçek zamanlı bildirimler desteklenmiştir.

### 6️⃣ DTO Layer (Veri Aktarım Katmanı)

* **Entity-DTO dönüşümleri** AutoMapper ile yönetilmektedir.
* Katmanlar arası veri taşınırken sadece ihtiyaç duyulan bilgiler gönderilerek performans artırılmıştır.

---

## 🔐 Kimlik Doğrulama ve Yetkilendirme

Projede kullanıcı ve admin panellerine erişim, **JSON Web Token (JWT)** tabanlı güvenlik altyapısı ile sağlanmıştır.
Kullanıcı giriş, kayıt ve rol bazlı yetkilendirme işlemleri bu sistem üzerinden yürütülmektedir.
Bu sayede, hem API hem de UI tarafında güvenli oturum yönetimi uygulanmıştır.

---

## ⚙️ Kullanılan Teknolojiler ve Kütüphaneler

| Kategori                    | Teknolojiler                                                    |
| --------------------------  | --------------------------------------------------------------- |
| 🧩 Back-End                | ASP.NET Core 8.0 (MVC), Web API, Entity Framework Core, MediatR |
| 🧱 Mimari                  | Onion Architecture, CQRS, Repository Pattern                    |
| 🔒 Güvenlik                | JWT, FluentValidation                                           |
| 🧠 Veri Transferi          | DTO, AutoMapper                                                 |
| 💬 Gerçek Zamanlı İletişim | SignalR                                                         |
| 🧪 Test & Dokümantasyon    | Swagger, Postman                                                |
| 🖥️ Front-End               | HTML5, CSS3, Bootstrap 5, JavaScript, jQuery                     |
| 💾 Veritabanı              | Microsoft SQL Server (MSSQL)                                    |

---

## 🖥️ Proje Bölümleri

### 👥 Vitrin (Kullanıcı Paneli)

* Araçları listeleme, filtreleme ve detaylı görüntüleme
* Rezervasyon oluşturma ve kullanıcı profili yönetimi
* Dinamik veri yükleme (AJAX) ile hızlı kullanıcı deneyimi

### 🧑‍💼 Yönetici Paneli (Admin)

* Araç, kullanıcı ve rezervasyon yönetimi
* Rol bazlı erişim kontrolü
* Modüler yapı sayesinde yeni sayfalar kolayca eklenebilir

---

## 🎯 Projenin Amacı

CarBook, sadece bir örnek uygulama değil; aynı zamanda **kurumsal düzeyde bir yazılım mimarisi pratiği** olarak tasarlandı.
Bu projeyle amacım, **modern yazılım mimarisi prensiplerini** (özellikle *SOLID* ve *Clean Code* ilkelerini) gerçek bir senaryoya uygulamaktı.
Front-end kısmı geliştirilmeye açık olmakla birlikte, backend mimarisi tamamen profesyonel standartlarda inşa edilmiştir.

Projede kullanılan **CarBook vitrin teması** ve **Xacton Admin paneli** arayüzleri, zaman kazandırmak ve modern bir görünüm elde etmek amacıyla entegre edilmiştir.

---

## 🙌 Teşekkür

Bu projede bana yol gösteren, fikirleriyle katkı sağlayan **Murat Yücedağ**’a,teşekkür ederim.

> “Kod sadece çalıştığında değil, okunabilir ve sürdürülebilir olduğunda değerlidir.”
>
> Sitemden Örnek Ekran Görüntüleri 




