using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] denemeDolap = new string[] {"buzdolabı","çamaşır makinesi","bulaşık makınesi" };

            for (int i = 0; i < denemeDolap.Length; i++)
            {
                Console.WriteLine(denemeDolap[i]);
            }
            


            Console.WriteLine("--------");
            //array diziler
            string[] kurslar = new string[] { "yazılımmcı yetiştirme kampı", "programlamaya başlangıç için temel kurs  kampı", "java","python" };

            //length eleman sayısı
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);//kurslar'ın i. elemanını yazdırır.
                Console.WriteLine("mertcan deniyor:)");

            }
            Console.WriteLine("sayfaların sonu footer");

            Console.WriteLine("--------");
            //for döngüsünün özelliği, bir başlangıç noktasından bir bitiş noktasına doğru, istediğimiz adım aralığında ilerleyebilmesidir.
            //foreach dizileri tek tek dolaşmaya yarar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            string[] tezgah = new string[] {"kumpir","mısır","sosisli" };

            for (int i = 0; i < tezgah.Length; i++)
            {
                Console.WriteLine(tezgah[i]);
            }

            foreach (string tezgahadı in tezgah)
            {
                Console.WriteLine(tezgahadı);
            }








        }
    }
}
