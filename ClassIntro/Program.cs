using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Eğitmen_2";
            kurs2.IzlenmeOranı = 90;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Eğitmen_3";
            kurs3.IzlenmeOranı = 75;

            Kurs kurs4 = new Kurs();
            kurs3.KursAdi = "Kurs_4";
            kurs3.Egitmen = "Eğitmen_4";
            kurs3.IzlenmeOranı = 13;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }


        }
    }

    class Kurs
    {
        //Büyük harfle Başla
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }

}
