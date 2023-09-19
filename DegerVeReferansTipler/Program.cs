using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine( sayi1);

            // sayi1 ? 

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0]= 999;
            Console.WriteLine(sayilar1[0]);
            // sayilar1[0] ?


            // sayısal veri tipleri, int,decimal,double,bool = deger tip
            // ancak array, class, interface bunlar karşımıza referans tip olarak karşımız çıkar. 
            // bellekte stack-heap diye iki alan vardır.değer tanımladığımızda ( int sayi1 = 1 gibi ) stackte gerçekleşir.
            // sayi1 =say2 dediğinde sayi2nin degerini alır ve önceki degeri atar. yani sonuç 30
            // ancak int [] sayilar1 diye değişken tanımladığında new dediğin anda sayilar1 için heapte yeni bir alan oluştur ve değeri oraya yaz demek.
            // yani sayilar1 in referans numarası = sayilar2nin referans numarası
            // ( deger tiplerde değeri atıyorsun, referans tiplerde referansı atıyorsun )
            // sayilar2[0] referans numarasını 100 ü 999 la değiştirdiğinde( sayilar2 = new [999,200,300] olur
            // ve sayilar1 de sayilar2nin referans numarasını tuttuğu için ve sayilar1[0] = 999 olur.
                  }
    }
}