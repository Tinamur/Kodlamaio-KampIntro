using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        //Operation Class

        //Burada Encapsulation yapıp gönderiyoruz ürünü doğru olan yöntem
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);
        }


        //Bu şekilde açık yazmak yanlış!!
        //Gelecekte Ürün için daha başka özellikler eklenirse Değişime
        //direnç gösterir - örnek biz stok adedi ekliyoruz şuan
        public void Ekle2(string urunAdi,double fiyat,string aciklama)
        {

        }

    }
}
