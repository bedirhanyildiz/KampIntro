using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Amasya Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 90;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Çilek";
            urun3.Fiyati = 30;
            urun3.Aciklama = "Kırmızı Çilek";

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("--------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 25);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 5, 60);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80, 170);





        }
    }
}
