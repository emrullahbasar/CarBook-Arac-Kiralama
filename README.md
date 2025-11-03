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
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 104944" src="https://github.com/user-attachments/assets/e1d875bc-d126-4779-bffa-4a81ac8400bb" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 104930" src="https://github.com/user-attachments/assets/67f452d2-3774-469f-a6c2-982f6d02a314" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 104923" src="https://github.com/user-attachments/assets/e5e33a28-7b80-4a16-a423-87acbb1d6ad7" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 104907" src="https://github.com/user-attachments/assets/7425efd7-30b2-42cb-8a96-b6908629df64" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 104845" src="https://github.com/user-attachments/assets/c70f5100-2dcb-4c9f-aca5-39b6784baeac" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 104817" src="https://github.com/user-attachments/assets/032aff09-43e1-4eaa-b164-0bb05800e685" />
<img width="1920" height="1080" alt="Ekran görüntüsü 2025-11-03 104556" src="https://github.com/user-attachments/assets/853ffb63-74c5-4cb4-a6df-938a464a618e" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 104526" src="https://github.com/user-attachments/assets/7ce989d7-209f-4aa6-97a7-e06a73d5a419" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105205" src="https://github.com/user-attachments/assets/8df20861-2f20-4881-a5a4-9bae550f7195" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105200" src="https://github.com/user-attachments/assets/f21a6708-05ca-423b-8871-c5c7ce3b103f" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105155" src="https://github.com/user-attachments/assets/80c5d008-f00d-4d2e-8ccc-ea2a5029ece9" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105141" src="https://github.com/user-attachments/assets/ed448176-a808-45d4-b620-8e1e493d7734" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105134" src="https://github.com/user-attachments/assets/3b8da919-f4a2-4c2f-ba80-c06a4170365f" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105115" src="https://github.com/user-attachments/assets/09698fea-9418-4bb3-8191-14d347cac299" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105103" src="https://github.com/user-attachments/assets/3d0e1d2c-3f10-4422-81bb-4bc0ccc47082" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105048" src="https://github.com/user-attachments/assets/ef9ec41a-1b79-4633-9e58-61d92660d204" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105032" src="https://github.com/user-attachments/assets/7426976a-179b-4ed3-ac2a-d21e61a05c24" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105019" src="https://github.com/user-attachments/assets/9da9c953-a416-46e9-b807-56e904803423" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105011" src="https://github.com/user-attachments/assets/3d15b714-069c-4fe1-8995-345a0c373638" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105003" src="https://github.com/user-attachments/assets/04e81977-9f6d-4479-a576-b607ab7c4494" />

