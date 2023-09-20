using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) // () içersindeki kısım hangi krediden başvurulacaksa onu kullanmamızı sağlar.
        {
            // başvuru bilgilerini değerlendirme


            //  KonutKrediManager konutKrediManager = new KonutKrediManager();
            //  konutKrediManager.Hesapla(); // bu ifadeyi kullanırsak tüm başvuruları konut kredisi başvurusuna göre almış oluruz. doğru değil

            krediManager.Hesapla();
            loggerService.Log();
        }

        private static void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
