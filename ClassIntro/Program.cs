namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Sena";
            int yas = 29;

            Kurs kurs1 = new Kurs();          // string, int gibi nasıl değişken tanımladıysak, bu şekilde de değişken tanımlayabilirsin.
                                            // class değişkeni tanımlamak için - new Kurs()
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Rumeysa";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Sena";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Özdemir";
            kurs3.IzlenmeOrani = 80;


            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar) //Kurs veri tipi
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen); 
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; } // prop tab tab
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}