# MVC-KurumsalMimari
Kurumsal Mimaride MVC Projesinin Gerceklenmesi

#Norwind.Entities
  Veritabanindan Cekecegimiz Tablolarin Koyulacagi Verileri Iceren Class Library

#Nortwind.DAL(Data Access Layer)
  Verilerin Veribanindan Alinip Entitieslere Doldurulmasi Saglayan Katmandir.
  
  Abstract Directory : Gerceklenecek ve Veritabanindan Cekilecek Olan Entitieslerin Interface Ile CRUD ve Extra Metodlarin Belirlenmesini Saglar.DAL Katmaninin Seklini Cikardir.Bu Sekilde Kullanacagimiz Framework ne Olursa Olsun Data Access Layer Katmanini Gercekleyecegimizde Sinirlarimiz Tum Frameworklerde Ayni Olur.
  
  Concrete Directory : Abstract Ile Sinirlari Belirlenmis Olan Entities'in Gerceklemesi Bu Directory Icinde Yapilir.Bu Directory Icinde Her Framework'e Gore Interface Farkli Sekillerde Gerceklenebilir.Iclerinde DatabaseContext Icerir.Bu Classta Veritabanindan Hangi Verilerin Cekilecegi Ayarlanabilir.
  
  
#Nortwind.BLL(Business Logic Layer)
  Application Layer ile Service Layer Ayni Makinede ise BLL Katmani DAL'ye Erismek Icin Kullanilmaktadir.

#Nortwind.WCFLibrary(Service Layer)
  Tum Makinelere Destek Verebilmek Icin Kullanilan Servis Katmani.
  
#Nortwind.Interfaces(BLL ve Service Layer Soyutlamasi)
  Katmanli Mimaride Service Layer veya BLL Kullanilabilir.2'si Birden Kullanilirsa Bunlarin Hangi Metodlara Sahip Olacagi Belirlenmesi Icin Kullanilan ve Hangisinin Kullanilacagi Belirlemek Icin Soyutlama Yapmamizi Saglayan Ara ClassLibrary
  
#Nortwind.MVCWeBIU(User Interface Layer)
  Kullanici Ile Etkilesimde Olan Katman 
  
  -NinjectControllerFactory : Service Layer ve BLL'de DAL'a Erisebilmek Icin Constructorlara Gerekli Parametreleri Ayarlamaktadir ve Logging Gibi Katmanlari Dikine Kesen Islemin Kaydida Burada Yapilmaktadir.
  
  -WcfProxy : WCF Service Icin ABC Ayarlamasi Yapmaktadir.{ A=Adress,B=Binding,C=Channel} Ayarlama Yapildiktan Sonra Kanali Olusturur.Olusturulan Kanal Ninject Sayesinde Service Kullanimini Saglar.
  
  -PagingHelpers : Sayfalama Her Sayfa Icin a-href Tagi Olusturmaya Yaratan Class 
  -ModelBinders : Sessiondan Her Metodda Alinmasi Gereken Entitiesi ModelBinder Kullanarak Parametre Seklinde Gelmesi Saglanmaktadir.
  -Global.asax : Defaul Ninject ve Model Binders'in Ayarlandigi Yer.
  
  **WCF Service Kullanimi Icin Web.config Dosyasina ConnectionString Yazilmasi Gerekmektedir.
  **BLL'de ise UI'de Yazilmasi Yeterlidir.
  
  
