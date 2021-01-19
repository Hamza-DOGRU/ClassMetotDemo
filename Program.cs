using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] Musteriler = new string[] { }; //Musteriler isimli bir dizi oluşturdum.
            Musteri musteri1 = new Musteri ();      //Diziye yeni bir eleman ekledim. Ve her class için oluşturduğum yeni elemanın değerlerini girdim.
            musteri1.Id = 1;
            musteri1.Adi = "Hakan";
            musteri1.Soyadi = "Öz";
            musteri1.Tel = "05366666666";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Elif";
            musteri2.Soyadi = "Korkmaz";
            musteri2.Tel = "05322222222";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ezgi";
            musteri3.Soyadi = "Çınar";
            musteri3.Tel = "05365555555";
            Musteri[] musteriler = new [] { musteri1, musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Listeleme(musteriler);
            musteriManager.Sil(musteri3);



        }
    }
}
