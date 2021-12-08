using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Dizi oluşturma
            string[] kurslar = new string[]
            {
                "String_Array_Elemanı_1",
                "String_Array_Elemanı_2",
                "String_Array_Elemanı_3",

            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("------------------");

            //C# Foreach
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
