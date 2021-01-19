using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] meyveler = new string[] { };

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

         
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kapruz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 20;
            urun3.Aciklama = "Manisa Armutu";


            Urun[] urunler = new Urun[] {urun1 , urun2,urun3 };

            //type - safe-- tip güvenliği
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("-------Metotlar--------");
            

            //instance- ornek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,8);






        }
    }
}


//Do not repeat yourself - DRY - Clean COde - Best Practice 
