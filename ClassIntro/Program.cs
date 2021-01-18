using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Bedirhan Yıldız";
            kurs1.izlenmeOrani = 67;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Kuzey Yiğit Yıldız";
            kurs2.izlenmeOrani = 99;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Pyhton";
            kurs3.egitmen = "Gizem Yıldız";
            kurs3.izlenmeOrani = 89;

            //Console.WriteLine(kurs1.kursAdi + " : " +kurs1.egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.egitmen);
            }
        }
    }


    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
