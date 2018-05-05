# Token-Authentication-Ornegi

### Kurulum

1. Proje dosyalarını kendi bilgisayarımıza yüklüyoruz.
```sh
$ git clone https://github.com/srdrmtl/Token-Authentication-Ornegi.git
```

2. Web.config dosyasında gerekli düzeltmeleri yapıyoruz.(connectionString değiştirilecek)

```sh
  <connectionStrings>
    <add name="MyLibraryEntity" connectionString="Data Source=SERDAR;Initial Catalog=Rezervasyon;Integrated Security=SSPI;" providerName="System.Data.SqlClient" />
  </connectionStrings>
```
3. Package Manager -> Update-Database komutunu yazıp Veritabanımızı oluşturuyoruz.

4. Projeyi çalıştırıp "http://localhost:63646/api/reservation" get methoduna ulaşmaya çalıştığımızda Authentication Hatası aldığımızı göreceksiniz.
5. "http://localhost:63646/token" post methoduna aşağıdaki key'leri yazıp token'imizi alıyoruz.

![N|Solid](http://resimag.com/93268fe9ba.png)

6. Daha sonra "http://localhost:63646/api/reservation" get methoduna token kodumuzu başına bearer yazarak ekliyoruz ve aşağıdaki gördüğünüz gibi
Authentication hatası almadan verileri görüntüleyebiliyoruz ( Veritabanında herhangi bir kayıt olmadığı için boş gözüküyor, isterseniz kendiniz kayıt ekleyerek
deneyebilirsiniz.

![N|Solid](http://resimag.com/c5dcd14e7f.png)
