using System;

namespace ClassIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            Kurs Kurs1 = new Kurs();
            Kurs1.Kursadı = "mertcan c#";
            Kurs1.KursunEğitmeni = "engin demiroğ";
            Kurs1.IzlenmeOranı = (57);

            Kurs kurs2 = new Kurs();
            kurs2.Kursadı = "elif c++";
            kurs2.KursunEğitmeni = "mert can";
            kurs2.IzlenmeOranı = (57);

            Kurs kurs3 = new Kurs();
            kurs3.Kursadı = "elif mertcan";
            kurs3.KursunEğitmeni = "mert can elif";
            kurs3.IzlenmeOranı = (571);

            // Console.WriteLine(Kurs1.Kursadı+" "+Kurs1.KursunEğitmeni);

            Kurs[] kurslar = new Kurs[] {Kurs1,kurs2,kurs3};


            //buradaki kurs takma isim
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadı+" : "+kurs.KursunEğitmeni);
            }


        }
    }




    //string bir metin tutarken class birden cok veriyi tutar
    class Kurs
    {
        public string Kursadı { get; set; }
        public string KursunEğitmeni { get; set; }
        public int IzlenmeOranı { get; set; }

    }




}
