using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun > dolarbugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolardun < dolarbugun)

            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
