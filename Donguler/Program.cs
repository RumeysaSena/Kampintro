namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string kurs1 = "Yazilim Geliştirici Yetişitrme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);   
            Console.WriteLine(kurs3);

            // değişkenler çok çok fazla olduğunda string gibi tek tek yazmak yerine dizilerde tanımlamalısın.

            // array - dizi
            // kurslar adında bir array oluşturup, istediğimiz kadar kursu tek bir değişkende tutabiliriz.

            string[] kurslar = new string[] 

            { 
                "Yazilim Geliştirici Yetişitrme Kampı", 
                "Programlamaya başlangıç için temel kurs",
                "Java" ,
                "Python", 
                "C#"
            };

            for (int i = 0; i <kurslar.Length; i++) // sayı artabilir, sonu yok, dinamizmi sağlamak adına kurslar.Length- kaç eleman varsa o kadar kullanır.
            {
                Console.WriteLine(kurslar[i]);  // i = sayaç- kurslar[i] - kursların i.elemanını yazdır demek
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar.Kursları, tek tek dolaş
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu -- footer");
        }
    }
}