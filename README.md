# Perispanya - Pastane Web Sitesi  

Bu proje, bir pastane için oluşturulmuş **Perispanya** adlı bir web sitesidir. Proje, **ASP.NET MVC** mimarisi kullanılarak geliştirilmiştir ve aşağıdaki katmanlar ile yapılandırılmıştır:  

- **BusinessLayer**  
- **DataAccessLayer**  
- **EntityLayer**  
- **DtoLayer**  
- **PresentationLayer**  

## 📚 Proje Hakkında  

**Perispanya**, pastanenin ürünlerini, kategorilerini ve diğer bilgilerini kolayca yönetebilmesi için bir **Admin Paneli** içermektedir. Admin panelinde aşağıdaki işlemler yapılabilmektedir:  

- **Kategori Yönetimi**  
  - Yeni kategori ekleme  
  - Mevcut kategoriyi güncelleme  
  - Kategoriyi silme  

- **Ürün Yönetimi**  
  - Yeni ürün ekleme  
  - Ürünü güncelleme  
  - Ürünü silme  

- **Hakkımızda (About) Yönetimi**  
  - Hakkımızda içeriklerini düzenleme  

- **Slider Yönetimi**  
  - Yeni slider ekleme  
  - Slider güncelleme  
  - Slider silme  

## 🛠️ Kullanılan Katmanlar ve Yapılar  

- **EntityLayer**: Veritabanı tablolarını temsil eden sınıflar. (About, Category, Product, Slider gibi)  
- **DtoLayer**: Veritabanından çekilen veya gönderilen veriler için kullanılan transfer objeleri.  
- **DataAccessLayer (DAL)**: Veritabanı işlemlerinin yapıldığı katman.  
- **BusinessLayer**: İş kuralları ve mantığının yer aldığı katman.  
- **PresentationLayer**: Web sitesi kullanıcı arayüzü ve admin panelinin bulunduğu katman.  

## 🚀 Özellikler  

- **Kullanıcı Dostu Arayüz**: Admin paneli, kullanıcıların kolayca işlem yapmasını sağlayan basit ve modern bir tasarıma sahiptir.  
- **CRUD İşlemleri**: Kategoriler, ürünler, hakkımızda içerikleri ve slider üzerinde ekleme, silme ve güncelleme işlemleri yapılabilir.  

## 💻 Teknik Detaylar  

- **Proje Türü**: ASP.NET MVC Web Projesi  
- **Veritabanı**: SQL Server
- **Dil**: C#  
- **Ön Yüz Teknolojileri**: HTML, CSS, JavaScript

## 📂 Proje Yapısı  

```plaintext  
├── BusinessLayer  
├── DataAccessLayer  
├── EntityLayer  
├── DtoLayer  
├── PresentationLayer  
    ├── Controllers  
    ├── Views  
    ├── Models  
```  

## 📷 Ekran Görüntüleri  

Websitesinden örnekler:
![Perispanya Web Sites](https://i.hizliresim.com/2fw5w48.png)  
![Perispanya Web Sites](https://i.hizliresim.com/rvfsn5t.png)  
![Perispanya Web Sitesi](https://i.hizliresim.com/7w7sos8.png) 
 
Admin panelinden örnekler: 
![Perispanya Admin Paneli](https://i.hizliresim.com/pfsz4t0.png)  
![Perispanya Admin Paneli](https://i.hizliresim.com/dbjthxb.png)  

## 🔧 Nasıl Kurulur?  

1. Bu repoyu klonlayın:  
   ```bash  
   git clone https://github.com/ozcanakyuz/Perispanya.git  
   ```  

2. **Connection String** ayarlarını kendi veritabanınıza göre güncelleyin.  
3. Veritabanını oluşturun ve tabloları Entity Framework ile migrate edin.  
4. Projeyi başlatmak için Visual Studio'da `F5` tuşuna basın.  

## 📄 Lisans  

Bu proje **MIT Lisansı** altında lisanslanmıştır. Daha fazla bilgi için [LICENSE](https://github.com/ozcanakyuz/Perispanya/blob/main/LICENSE) dosyasını inceleyebilirsiniz.  
