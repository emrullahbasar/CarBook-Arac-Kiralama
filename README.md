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

> **“Kod sadece çalıştığında değil, okunabilir ve sürdürülebilir olduğunda değerlidir.”**



**Sitemden Örnek Ekran Görüntüleri** 
>Ana Sayfa ve Giriş Alanı
<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113517" src="https://github.com/user-attachments/assets/a645a506-336f-4bb1-b093-f224462401f7" />

>Kiralama Alanı

<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113532" src="https://github.com/user-attachments/assets/cee35009-386e-4dc0-9da8-fe550ea35ca1" />

>Öne Çıkan Araçlar

<img width="1906" height="943" alt="Ekran görüntüsü 2025-11-03 113612" src="https://github.com/user-attachments/assets/cb4d4804-d576-4730-9234-c50ef9692154" />

>Mutlu Müşteriler

<img width="1902" height="940" alt="Ekran görüntüsü 2025-11-03 113639" src="https://github.com/user-attachments/assets/72ee9916-074b-4ced-856d-13bbe5e4ffb3" />

>Ana Sayfadaki İstatistikler

<img width="1899" height="941" alt="Ekran görüntüsü 2025-11-03 113654" src="https://github.com/user-attachments/assets/4f0388a2-abd1-47a1-bc51-8056feebdf95" />

> Araçların Listesi 

<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 113719" src="https://github.com/user-attachments/assets/ad24e869-ba2c-46e2-9240-21a17c0b46c5" />

>Fiyatlar İle Birlikte Araç Listesi

<img width="1903" height="944" alt="Ekran görüntüsü 2025-11-03 113735" src="https://github.com/user-attachments/assets/a9ef166e-4a1c-45ba-bcea-de0a50eb0e79" />

>Hizmetler ve Kullanıcılar İle Yapılacak Etkinlikler

<img width="1901" height="940" alt="Ekran görüntüsü 2025-11-03 113757" src="https://github.com/user-attachments/assets/f36daad2-2f1d-4627-92c2-f5148650db8e" />

>Bloglar Kısmındaki Son Bloglar

<img width="1901" height="941" alt="Ekran görüntüsü 2025-11-03 113810" src="https://github.com/user-attachments/assets/36a59be3-6b29-4836-8eef-a1afca731196" />

>Blog Örneği

<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 113830" src="https://github.com/user-attachments/assets/291c851f-4357-4a94-ab1d-d8060d7de34b" />

>Biz Kimiz 

<img width="1903" height="943" alt="Ekran görüntüsü 2025-11-03 113852" src="https://github.com/user-attachments/assets/7f9f01e7-5eb4-4622-84a6-8b49dbb82081" />

>Admin Kısmındaki Araç Listesi ve Bu Bölümden Düzenlemeler Yapılmaktadır

<img width="1904" height="943" alt="Ekran görüntüsü 2025-11-03 114048" src="https://github.com/user-attachments/assets/25a55beb-d7ba-4aa0-b414-2ff50d1e42ad" />

>Araçlarda Bulunan Özellikler Listesi 

<img width="1902" height="942" alt="Ekran görüntüsü 2025-11-03 114104" src="https://github.com/user-attachments/assets/55b08cf2-87da-4b3f-9ac1-4a8e06175dcb" />

>CarBook Bünyesindeki Araçların Markaları

<img width="1903" height="945" alt="Ekran görüntüsü 2025-11-03 114115" src="https://github.com/user-attachments/assets/7414df08-61b7-4cbe-b961-f6c6ad701d6d" />

>Kiralanın Araçların Teslim Edilebileceği Noktalar

<img width="1904" height="942" alt="Ekran görüntüsü 2025-11-03 114127" src="https://github.com/user-attachments/assets/eb736ec8-f3df-440b-a818-4a1c3e28ee70" />

>Blog İşlemlerinin Düzenlendiği Alan

<img width="1916" height="945" alt="Ekran görüntüsü 2025-11-03 114139" src="https://github.com/user-attachments/assets/861f2cf7-8af5-4797-bcc8-3188d2e9b98c" />

>Genel Bilgilerin Hakim Olduğu Bölüm

<img width="1903" height="942" alt="Ekran görüntüsü 2025-11-03 114210" src="https://github.com/user-attachments/assets/3bf99d45-969f-4e17-8e76-72bf0ebdd640" />

>GeneL İstatistiklerin Gösteriminin Yapıldığı Bölüm

<img width="1918" height="942" alt="Ekran görüntüsü 2025-11-03 114222" src="https://github.com/user-attachments/assets/0c592a01-24a0-4bed-956a-026c21e5230d" />



