using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriId+" "+musteri.musteriAdi+" "+musteri.musteriSoyadi+" "+musteri.musteriNo+ " -> Müşteri Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("ID: "+musteri.musteriId + " -> Silme işlemi tamamlandı");
        }

        public void Listele(Musteri[] musteriler)
        {

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID: " + musteri.musteriId + " " + "Müşteri Adı ve Soyadı: " + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + "Müşteri No: " + " " + musteri.musteriNo);
            }
        }
    }
}
