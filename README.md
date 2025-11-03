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

<img width="1916" height="945" alt="Ekran görüntüsü 2025-11-03 114139" src="https://github.com/user-attachments/assets/0459467e-e78c-4c29-a8d9-64b1e11598d9" />
<img width="1904" height="942" alt="Ekran görüntüsü 2025-11-03 114127" src="https://github.com/user-attachments/assets/66685547-d36e-4c30-b691-40a6f5221e0f" />
<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 114115" src="https://github.com/user-attachments/assets/4df2e121-4550-405a-8869-aa2f343f360c" />
<img width="1902" height="942" alt="Ekran görüntüsü 2025-11-03 114104" src="https://github.com/user-attachments/assets/76897ab6-5dbc-41a2-b448-36810268b48e" />
<img width="1904" height="943" alt="Ekran görüntüsü 2025-11-03 114048" src="https://github.com/user-attachments/assets/cc58ccc5-20ac-4bfd-9b0d-d9308fee8382" />
<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113852" src="https://github.com/user-attachments/assets/534f03c5-451d-4581-847f-148f0691daf5" />
<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 113830" src="https://github.com/user-attachments/assets/f42078b8-916a-4278-89c9-7b91052d1fbc" />
<img width="1901" height="941" alt="Ekran görüntüsü 2025-11-03 113810" src="https://github.com/user-attachments/assets/69725ed9-2275-411f-95a3-4176adf4ab49" />
<img width="1901" height="940" alt="Ekran görüntüsü 2025-11-03 113757" src="https://github.com/user-attachments/assets/f43b3fc1-0526-417d-abdf-521315101d48" />
<img width="1903" height="944" alt="Ekran görüntüsü 2025-11-03 113735" src="https://github.com/user-attachments/assets/0b1be129-cca0-409e-8ac2-b41b369b28d6" />
<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 113719" src="https://github.com/user-attachments/assets/b5087499-3d39-490d-b28c-1895cf93d0d6" />
<img width="1899" height="941" alt="Ekran görüntüsü 2025-11-03 113654" src="https://github.com/user-attachments/assets/9736448b-6ad0-42c9-9bdc-00dba637ae5a" />
<img width="1902" height="940" alt="Ekran görüntüsü 2025-11-03 113639" src="https://github.com/user-attachments/assets/3419dddf-4f72-47ce-b049-8cedb56a73ff" />
<img width="1906" height="943" alt="Ekran görüntüsü 2025-11-03 113612" src="https://github.com/user-attachments/assets/116444af-2018-4043-af1e-026d92b8b704" />
<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113532" src="https://github.com/user-attachments/assets/02679425-4ac4-435f-a74d-fe32bdc6fcdb" />
<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113517" src="https://github.com/user-attachments/assets/ac60217d-088c-4d45-9e9a-9418f4faba6a" />
<img width="1920" height="1032" alt="Ekran görüntüsü 2025-11-03 105155" src="https://github.com/user-attachments/assets/4096fc4a-3f78-4684-b89e-52a887cf0fdf" />
<img width="1918" height="942" alt="Ekran görüntüsü 2025-11-03 114222" src="https://github.com/user-attachments/assets/4d66224e-9ddd-4dbf-97bb-45b87157ea45" />
<img width="1903" height="942" alt="Ekran görüntüsü 2025-11-03 114210" src="https://github.com/user-attachments/assets/df385c2e-a433-46fe-9f4a-67824299397e" />
<img width="1916" height="944" alt="Ekran görüntüsü 2025-11-03 114159" src="https://github.com/user-attachments/assets/b0c1d1d6-0bfd-4acb-9481-580e96f905c6" />


