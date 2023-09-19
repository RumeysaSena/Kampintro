using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Rumeysa", "Sena", "Özdemir" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            ////arrayler onu oluşturduğumuz sınırlarda takılırlar sadece. dışarıdan isimler[3]="asd"; şeklinde yeni bir 3.eleman oluşmaz. 

            //isimler = new string[4];
            //isimler[3] = "abcd";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]); // değerleri kaybederiz. 0.eleman boş gelir. ancak List ile yaparsak;

            List<string> isimler2 = new List<string> { "Rumeysa", "Sena", "Özdemir" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("abcd");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]); // koleksiyonlarda arraylar gibi değerleri kaybetmizi engelleyecek alt yapı

        }
    }
}