# FinancialCrm
Bu projemiz C# Form Application ile yazılmış. Entity Framework Teknolojisinden faydalanılmıştır. Yazılırken Veri tabanı olarak Sql Server Kullanılmış. DbFirst mantıgı ile veritabanı oluşturulmuştur.

Form ilk açıldıgında bizi bir Kullanıcı Giriş Sayfası Karşılamakta ve giriş yanlışsa sisteme girmeye izin vermemektedir.
<img src="user.JPG" width="200px;" Height="auto;">
<br>
Sisteme Giriş Dogru ise ;
<br>
Bizi Dashboard Sayfasına atmakta. 
<br><br>
<b>Dashboard Sayfasında bizi;</b>
<br>
<ul>
  <li>Toplam Bakiye</li>
  <li>Fatura Giderleri</li>
  <li>Gelen Son Havale</li>
  <li>Faturalarla ve Bankalarla ilgili Grafikler</li>
</ul>
karşılamakta.

<img src="dashboard.JPG" width="600px;" Height="auto;">


<br><br>
<b>Ayarlar Sayfasında bizi;</b>
<br>Kullanıcı ve Şifre Değiştirme ve Kullanıcı Listesi Karşılamakta.

<img src="settings.JPG" width="600px;" Height="auto;">



<br><br>
<b>Kategoriler Sayfasında bizi;</b>
<ul>
  <li>Kategori Listesi</li>
  <li>Yeni Kategori Ekleme</li>
  <li>Kategori Güncelleme</li>
  <li>Kategori Silme</li>
</ul>
 gibi işlemler karşılamakta.

<img src="kategoriler.JPG" width="600px;" Height="auto;">



<br><br>
<b>Bankalar Sayfasında bizi;</b>
<ul>
  <li>Yeni Hesap Ekleme</li>
  <li>Hesap Güncelleme</li>
  <li>Hesap Silme</li>
  <li>Banka ve işlem tipine göre Hesap Hareketi Ekleme</li>
</ul>
 gibi işlemler karşılamakta.


Bankalar formu açılırken "Banka Hareketleri" kısmındaki Banka kısmı veritabanından otomatik çekilmektedir.
İşlem Tipi "Gelen havale" ise veritabanında Bank Process Tablosuna hesap hareketi olarak veri eklenmekte. Ayrıca Seçili bankaya göre o hesaba para girişi olmaktadır.
İşlem Tipi "Giden havale" ise veritabanında Bank Process Tablosuna hesap hareketi olarak veri eklenmekte. Ayrıca Seçili bankaya göre o hesabtan para gideri olmaktadır.<br>
<img src="bankavehareketekleme.JPG" width="600px;" Height="auto;">



<br><br>
<b>Faturalar Sayfasında bizi;</b>
<ul>
  <li>Fatura Listesi</li>
  <li>Yeni Fatura Ekleme</li>
  <li>Fatura Güncelleme</li>
  <li>Fatura Silme</li>
</ul>
 gibi işlemler karşılamakta.

<img src="faturalar.JPG" width="600px;" Height="auto;">



<br><br>
<b>Giderler Sayfasında bizi;</b>
<ul>
  <li>Gider Listesi</li>
  <li>Yeni Gider Ekleme</li>
  <li>Gider Güncelleme</li>
  <li>Gider Silme</li>
  <li>Toplam bakiye Gösterme</li>
  <li>Toplam Gider Gösterme</li>
</ul>
 gibi işlemler karşılamakta.
<br>
 Ayrıca kategoriler comboboxa form yüklenirken veritabanından gelmektedir.

<img src="giderler.JPG" width="600px;" Height="auto;">

<br><br>
<b>Banka Hareketleri  Sayfasında bizi;</b>
<ul>
  <li>3 bankaya ait hesaptaki Para<li>
  <li>Son 5 Banka Hareketi </li>

</ul>
 gibi işlemler karşılamakta.
<br>
 
<img src="bankalar.JPG" width="600px;" Height="auto;">

