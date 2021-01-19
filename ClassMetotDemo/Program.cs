using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAdi = "Çağrı";
            musteri1.musteriSoyadi = "Karabaş";
            musteri1.musteriNo = 123;

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriAdi = "Serdar";
            musteri2.musteriSoyadi = "Tatsızoğlu";
            musteri2.musteriNo = 124;

            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 3;
            musteri3.musteriAdi = "Bartuğ";
            musteri3.musteriSoyadi = "Kesilmez";
            musteri3.musteriNo = 125;

            MusteriManager musteriYönetimi = new MusteriManager();
            musteriYönetimi.Ekle(musteri1);
            musteriYönetimi.Ekle(musteri2);
            musteriYönetimi.Ekle(musteri3);


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriYönetimi.Listele(musteriler);

            
            musteriYönetimi.Sil(musteri3);
        }
    }
}
