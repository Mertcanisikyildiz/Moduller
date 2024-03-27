


using Moduller;
Console.WriteLine("Metot Dersi");


Urun ürün1  = new Urun();
ürün1.Adı = ("Elma");
ürün1.Açıklama = ("Amasya");
ürün1.Fiyat = 9 ;


Urun ürün2 = new Urun();
ürün2.Adı = ("Karpuz");
ürün2.Açıklama = ("Diyarbakır");
ürün2.Fiyat = 19;


Urun[] ürünler = new Urun[] {ürün1 , ürün2 };

foreach (Urun urun in ürünler)
{
    Console.WriteLine(urun.Adı + " " + urun.Açıklama );

   

}

Console.WriteLine("---------Metotlar---------------");


SatışManager satışManager = new SatışManager();

satışManager.Ekle(ürün1);

satışManager.Ekle(ürün2);

satışManager.Ekle2("Armut", "Yumuşak", 19 , 5);
satışManager.Ekle2("Ayva", "Yumuşak", 19,9);
satışManager.Ekle2("Mandalina", "Yumuşak",9, 19);
satışManager.Ekle2("Çilek", "Yumuşak", 19,6);

