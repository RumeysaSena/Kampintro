using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
         //   ıhtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
         //   tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
         // konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager ,new DatabaseLoggerService()); // ekrandan ihtiyaç kredisini seçtiğini düşün. onu hesaplar. içerisine konurkredi yazsaydık onu hesaplardı.


            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager, tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); 
        }
    }
    
}