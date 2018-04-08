using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Örnek_6
{
    class Program
    {

        static void Main(string[] args)
        {
            int islem = default(int);
            bool sorgulama = default(bool);
            char sonuc=default(char) ;

            Dictionary<int, string> _islem = new Dictionary<int, string>();
            _islem.Add(0, "Doktor Girişi");
            _islem.Add(1, "Hasta Girişi");

            do
            {

                foreach (var isl in _islem)
                {
                    Console.WriteLine(isl);
                }

                Bosluk();

                Console.Write("Yapmak İstediğiniz İşin Kodunu Belirtiniz : ");
                islem = Convert.ToInt32(Console.ReadLine());
                Bosluk();

                switch (islem)
                {
                    case 0:
                        Doktorlar dok = new Doktorlar();
                        break;
                    case 1:
                        Hastalar hasta = new Hastalar();
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız..\nProgram Kapatılıyor.!");
                        break;
                }
                Bosluk();
                Console.WriteLine("İşleme Devam Etmek İstiyor Musunuz ?-{E},{H}");
                sonuc = Convert.ToChar(Console.ReadLine());
                if (sonuc == 'E')
                {
                    sorgulama = true;
                    Bosluk();
                }
                else if (sonuc=='H')
                {
                    sorgulama = false;
                    Bosluk();
                    Console.WriteLine("Program Kapatılıyor");
                    Environment.Exit(0);

                }
                else
                {
                    Bosluk();
                    Console.WriteLine("Lütfen Doğru Key Girişi Yapınız");
                    continue;
                }
            } while (sorgulama != false);
            
            Console.ReadKey();
        }

        public static void Bosluk()
        {
            Console.WriteLine();
        }

    }
    
}
