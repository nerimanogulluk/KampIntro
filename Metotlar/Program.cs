using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya elması";

           /* string urunAdi2 = "çilek";
            double fiyati2 = 10;
            string aciklama2 = "çilek gibi çilek";
           */

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (var urun in urunler) //type-safe -- tip güvenli 
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------------metotlar-----------------"); //CW kısa yol
            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "yeşil armut", 12, 13);
            sepetManager.Ekle2("karpuz", "yeşil armut", 12, 24);
        }
    }
}










