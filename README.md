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
<img width="1918" height="942" alt="Ekran görüntüsü 2025-11-03 114222" src="https://github.com/user-attachments/assets/c5adc99b-9a42-49b3-bd2b-74821af09e53" />
<img width="1903" height="942" alt="Ekran görüntüsü 2025-11-03 114210" src="https://github.com/user-attachments/assets/baf37d27-c845-4405-a894-4eb99123121a" />
<img width="1916" height="944" alt="Ekran görüntüsü 2025-11-03 114159" src="https://github.com/user-attachments/assets/0ecb5980-8275-4435-bb43-7ab107ffaa2c" />
<img width="1916" height="945" alt="Ekran görüntüsü 2025-11-03 114139" src="https://github.com/user-attachments/assets/830ebabf-1ac6-4631-8bbe-c2a8d3341ee4" />
<img width="1904" height="942" alt="Ekran görüntüsü 2025-11-03 114127" src="https://github.com/user-attachments/assets/b61c3228-9f8f-44b6-862a-ed99b32f476c" />
<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 114115" src="https://github.com/user-attachments/assets/34ee0494-f613-4419-912f-305053c9e7bf" />
<img width="1902" height="942" alt="Ekran görüntüsü 2025-11-03 114104" src="https://github.com/user-attachments/assets/71853511-540f-424c-9db2-f4d7ea899a11" />
<img width="1904" height="943" alt="Ekran görüntüsü 2025-11-03 114048" src="https://github.com/user-attachments/assets/184e8360-dc89-4000-af1a-e338278b526e" />
<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113852" src="https://github.com/user-attachments/assets/4c5949ed-6231-4217-a773-5dc5b3109822" />
<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 113830" src="https://github.com/user-attachments/assets/cb4f599e-4c32-451d-aaa0-686bb2bd6e59" />
<img width="1901" height="941" alt="Ekran görüntüsü 2025-11-03 113810" src="https://github.com/user-attachments/assets/0b3368e7-0802-4323-98ae-ba0220a8240a" />
<img width="1901" height="940" alt="Ekran görüntüsü 2025-11-03 113757" src="https://github.com/user-attachments/assets/996aac92-e6ac-4c55-81d5-e13d78502a61" />
<img width="1903" height="944" alt="Ekran görüntüsü 2025-11-03 113735" src="https://github.com/user-attachments/assets/37d75dc4-20ef-4091-9876-2d584386109d" />
<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 113719" src="https://github.com/user-attachments/assets/b993d266-8988-4072-8806-69cbf73cfdda" />
<img width="1899" height="941" alt="Ekran görüntüsü 2025-11-03 113654" src="https://github.com/user-attachments/assets/9bcb0955-94c4-4412-adcf-0be8765e3514" />
<img width="1902" height="940" alt="Ekran görüntüsü 2025-11-03 113639" src="https://github.com/user-attachments/assets/d080c482-2421-4cd7-89fa-ab8936191866" />
<img width="1906" height="943" alt="Ekran görüntüsü 2025-11-03 113612" src="https://github.com/user-attachments/assets/2708ee32-7749-47bf-a3a1-846c9b7a2a09" />
<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113532" src="https://github.com/user-attachments/assets/5101cde7-9b52-445a-91d0-24a902d3ca1e" />
<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113517" src="https://github.com/user-attachments/assets/351dcd57-bf82-4b7c-b383-7e314a99788b" />


