using System;

namespace Kampintronew
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip guvenlıgı
            // değer tutucu,alias
            string kategorietiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faizorani = 1.42;
            bool SistemegirisYapmisMi = true;
            double DolarDun = 8.45;
            double DolarBugun = 8.50;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("azalış oku");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("artış oku");
            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }


            if (SistemegirisYapmisMi==true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
              

            Console.WriteLine(kategorietiketi);
            Console.WriteLine(kategorietiketi);
            Console.WriteLine(kategorietiketi);


            Console.WriteLine("---------------");

            string dukkan = "yılmaz sogutma";
            int EvvelkiSenecalisansayisi = 5;
            int BuSeneCalisanSayisi = 6;
            double AcilisSaati = 8.30;
            bool DükkanAcikmi= true;

            if (EvvelkiSenecalisansayisi>BuSeneCalisanSayisi)
            {
                Console.WriteLine("çalışan sayısı yükselmiş");

            }
            else if (EvvelkiSenecalisansayisi<BuSeneCalisanSayisi)
            {
                Console.WriteLine("calısan sayısı düşmüş");
            }
            else
            {
                Console.WriteLine("çalışan sayısı aynı kalmış");
            }






               
        }
    }
}
