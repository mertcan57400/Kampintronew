using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyatı = 74;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun TakmaIsim in urunler)
            {
                Console.WriteLine(TakmaIsim.Adi+" "+TakmaIsim.Fiyatı+" "+TakmaIsim.Aciklama );
            }

            Console.WriteLine("----------Metotlar------------");
            //instance örnek    
            //encapsulation - kapsülleme
            
            sepetmanager sepetmanager = new sepetmanager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            
        }
    }
}
