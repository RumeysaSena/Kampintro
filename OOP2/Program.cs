using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sena özdemir

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id= 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Sena";
            musteri1.Soyadi = "ÖZDEMIR";
            musteri1.TcNo = "123456789";

            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54213";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345678978";
            

            // Gerçek Müşteri - Tüzel Müşteri- birbirinin yerine asla kullanılamaz.
            //SOLID

            Musteri musteri3= new GercekMusteri() ;
            Musteri musteri4 = new TuzelMusteri() ;

            MusteriManager musteriManager = new MusteriManager() ;
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2 );


            
        }
    }
}