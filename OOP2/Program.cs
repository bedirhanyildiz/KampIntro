using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Kuzey Yiğit";
            musteri1.Soyadi = "Yıldız";
            musteri1.TcNo = "145698544554";


            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "56486787";
            musteri2.Id = 2;
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "544487545";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            
                

        }
    }
}
