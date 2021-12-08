using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# özellikleri
            //c# type safety - tip güvenli
            //stringler kesin çift tırnak
            //noktalı virgül şart
            //Do not repeat yourself

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMı = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Azaldığını göster");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Dalar Artmış olarak göster");
            }
            else
            {
                Console.WriteLine("Dolar Değişmedi olarak göster");
            }

            if (sistemeGirişYapmışMı == true)
            {
                Console.WriteLine("Giriş Yapılmış Ekranı");
            }
            else
            {
                Console.WriteLine("Giriş Yap Ekranı");
            }
        }
    }
}
