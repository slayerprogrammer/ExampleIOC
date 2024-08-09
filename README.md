---

ASP.NET Core Inversion Of Control(IoC) / Dependency Injection Kavramları
Inversion Of Control (IoC)
Yazılım dünyasını takip eden herkes IoC, Dependency Inversion veya Dependecy Injection bu kavramları illa ki duymuştur. 
İlk olarak Inversion Of Control kavramına ve bu kavramla beraber kullanılan diğer kavramlarının ne olduğunu detaylı bir şekilde inceleyeceğiz. Bu kavramlar birbirine benzerlik gösteren arkadaş kavramlardır. Bu yazımızda sadece teorik olarak değil bir uygulama inşa ederek öğrendiğimiz teorik bilgiyi uygulayarak pratiğe dönüştürmüş olacağız. O halde gelin biraz daha yakından bakalım.
Inversion Of Control kavramına tabloda da gördüğünüz gibi Principle kavramı karşılık gelmektedir. Peki nedir bu Principle ?
Principle; uygulama geliştirirken veya kodlama yaparken bize yol gösteren kavramdır. 
Örneğin S.O.L.I.D. prensiplerinden olan  Single Responsibility Principle; 
Bir Class'ın değişmesi için tek bir nedeni olmalıdır. Aslında bize bir yol gösteriyor fakat bu yolu nasıl gerçekleştireceğimizi bize bırakıyor. Burada nihai amaç bir Class'ın değiştirilmek için tek bir nedeni olmalı, her bir classın bir amacı olmalıdır. 
Bir Class aynı anda hem SMS gönderip hem de Email göndermemelidir. 
Peki Inversion Of Control Principle' ın nasıl çalıştığını birkaç örnekle inceleyelim.
Inversion Of Control' ün karşılığını biri gerçek hayattan diğeri ise Object Oriented dünyasından örneklerle ele alalım.
Gerçek hayattan örneği verecek olursak evinizden işinize kendi aracınızla gidiyorsunuz.  Kendi aracınızla gittiğiniz zaman siz bu araç üzerinde hakimiyet sahibisiniz. Aracın lastiği patlasa, yağı azalsa bu gibi bakımlarını yapmanız gerekiyor. Burada Inversion Of Control diyor ki; 
Siz evden işyerine giderken araç üzerinde hakimiyet tamamıyla sizde olmasın. Evden işe giderken bu işi başka birine devret. Örneğin geliş gidişlerinizi taksiyle yapabilirsiniz. Yani nihai amacınız evden işe gitmek için kendi aracınızla değil de bir taksiyle bu işlemi çözmeniz. Taksiyle bu işi çözdüğünüzde öncelikle aracın bakımını siz düşünmek zorunda değilsiniz. Bu işleri düşünecek olan sizin sorumluluğu verdiğiniz şofördür. 
Birde yukardaki resimde ki alt görseli inceleyelim. Bizim bir A Class'ımız var bu A Class'ın içinde birde B Class'ı kullanıyoruz. Bu A Class'ı görevini yerine getirebilmek için B Class'ına mutlaka ihtiyaç duymaktadır. 
Bu A Class'ı B Class'ını kullanmak için new anahtar sözcüğüyle beraber bir nesne örneği alıyor. 
Nesne örneğini aldığı zaman yaşam döngüsü tamamen A Class'ında oluyor. 
Burada Inversion Of Control diyor ki;
Bir A Class'ı B Class'ı üzerinde hakimiyet kurmasın. A Class'ı B Class'ına ihtiyaç duyuyorsa bunu başkasına delege etsin bu B Class'ının oluşturulma işlemini ve delege etmiş olduğu yapı bana B Class'ında bir nesne örneği versin. Bu sayede A Class'ı sadece kendi işine odaklanabilir. Ve B Class'ının yaşam döngüsüne de müdahale etmeyecektir. 
Aslında nihai amacı bir uygulama geliştirken birbirine sıkı sıkı bağlı kodlar (Tight Coupling) yazmak yerine birbirine gevşek bağlı (Loose Coupling) kodlar yazmamıza imkan vermesidir. 
Bir uygulama geliştirirken yeni gelen Feture için yazdığımız kodları bozmayacaktır.
Dependency Inversion (DIP)
Inversion Of Control ve Dependency Inversion bu Principler kendilerini tamamlayan, omuz omuza çalışan prensiptir. Class'lar veya Object'ler arasındaki bağları kaldırmayı hedefleyen bir prensiptir. 
Şöyle düşünelim Bir A ve B Class'ımız var. Yukarıda bahsedilen örnekteki gibi A ve B Class'ları birbirine sıkı sıkı bağlıdır. Burada B Classında bir değişiklik yapıldığında haliyle A classında da değişiklik yapılması gerekmektedir. Dependency Inversion' a göre A Class'ı ile B Class'ı birbirini tanımasın veya birbirini tam olarak bilmesin. Bunun için Interface veya Abstract Class gibi bir ara Katman kullanılması gerekir. 
Dependency Injection (DI)
Dependency Injection bir tasarım kalıbıdır. ASP.Net Core tarafında geliştirme yaparken çoğunlukla duyarız. DI bizim yazılım bileşenlerindeki sıkı bağı azaltmaya yardımcı olan bir tasarım kalıbıdır.
Tasarım kalıpları: Kodlama yaparken karşılaştığımız problemlere tekrar tekrar kullanılabilir çözümler sunan yapılardır. 
Uygulamalarımızın ileriki aşamalarında bir değişiklik yapmak istediğimiz zaman çok daha az zahmetle bu işi gerçekleştirebileceğiz. 
Unit Testlerimizi yazarken bize birçok kolaylık sağlayacak. İlgili Class'larımızı kolay bir şekilde Mock'layabilmemizi olanak sağlayacak. 
Unit Test yazabilmek için projemizin bazı prensipleri ve bazı Tasarım Kalıplarını uygulamış olması gerekiyor. Her projeye kolay bir şekilde Unit Test yazamayabilirsiniz. Eğer ki projenizde DI gibi bir tasarım desenini kullanmadıysanız Mock'layamazsınız. 
Inversion Of Control Container (IoC)
Bu terim aslında Framework'lerin genel isimleridir. Örneğin Autofact, Ninject, Unity vs.
Peki Framework'ler ne iş yapar ? Yukarıda bahsetmiş olduğumuz Presip ve Tasarım Kalıplarını otomatikleştiren Framework'tür. Bu Framework'ler sayesinde daha az kod yazmış olup böylelikle Prensip ve Tasarım kalıplarını kullanmış olursunuz.
IOC / DIP / DI / Tightly Coupled / Loosely Coupled
Bu yukarıda anlatmış olduğum kavramları adım adım pratiğe dönüştürme işlemini gerçekleştireceğiz. Basit bir uygulama inşa ederek bu uygulamamız içinde 2 tane Class'ımız olacak bu Class'lar birbirine Tightly Coupled şeklinde bağlanmış olacak ve daha sonra adım adım implemantasyonları gerçekleştirerek Loosely Coupled classlar oluşturmaya çalışacağız. Burada basit bir Console uygulamasıyla örneğimizi gerçekleştireceğiz. 
Öncelikle Product, DataAccessLayer ve BusinessLogic olmak üzere 3 tane Class'ımız olacak. Buradaki veriyi de Program.cs den okuyor olacağız. 
