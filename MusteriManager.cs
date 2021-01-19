using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Yeni Müşteri Başarıyla Eklendi...");
            Console.WriteLine(musteri.Id + "Adı:" + musteri.Adi + " Soyadı:" + musteri.Soyadi + " Telefon No:" + musteri.Tel);

        }
        public void Sil(Musteri musteri) 
        {
            Console.WriteLine("Mevcut Müşteri Başarıyla Silindi...");
            Console.WriteLine(musteri.Id + "Adı:" + musteri.Adi + " Soyadı:" + musteri.Soyadi + " Telefon No:" + musteri.Tel);

        }
        public void Listeleme(Musteri[] musteriliste)
        {
            Console.WriteLine("Mevcut Müşteri Listesi Listelendi...");
            foreach (var musteri in musteriliste)
            {
                
                Console.WriteLine(musteri.Id + "Adı:" + musteri.Adi + " Soyadı:" + musteri.Soyadi + " Telefon No:" + musteri.Tel);
            }
        }
    }
}
