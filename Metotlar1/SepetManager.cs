using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar1
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("tEBRİKLER. Sepete eklendi : "+urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("tEBRİKLER. Sepete eklendi : " +"Urun adı :"+ urunAdi+"Stok ADEDİ:"+stokAdedi);
        }
    }
}
