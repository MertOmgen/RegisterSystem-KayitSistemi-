using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Örnek_6
{
    class Doktorlar
    {
        private string isim = string.Empty;
        private int id = default(int);
        private int adet = default(int);
        private bool idgiris = default(bool);
        private bool isimgiris = default(bool);

        public Doktorlar()
        {
            try
            {
                Console.Write("Kaç Adet Doktor Girilecek : ");
                adet = Convert.ToInt32(Console.ReadLine());
                Bosluk();
                var regexItem = new Regex("^[a-zA-Z\x20]*$");

                Dictionary<int, string> _Doktorlar = new Dictionary<int, string>();

                do
                {

                    for (int i = 0; i < adet; i++)
                    {
                        if (idgiris == false)
                        {
                            Console.Write("Doktor ID'sini Belirtin : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            idgiris = true;
                            Bosluk();
                        }

                        if (isimgiris == false)
                        {
                            Console.Write("Doktor İsmini Yazınız : ");
                            isim = Console.ReadLine();
                            isimgiris = true;
                        }

                        if (!regexItem.IsMatch(isim))
                        {
                            Bosluk();
                            Console.WriteLine("Lütfen İsim Girerken Özel Karakter veya Rakam Kullanmayınız.!");
                            isimgiris = false;
                            Bosluk();
                            continue;
                        }
                        isimgiris = false;
                        idgiris = false;
                        Bosluk();
                        _Doktorlar.Add(id, isim);

                    }

                } while (!regexItem.IsMatch(isim));

                foreach (var doktor in _Doktorlar)
                {
                    Console.WriteLine(doktor);
                }
                Bosluk();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hatalı İşlem Yaptınız-->{0}",ex.Message);
            }
           
        }
        
        public void Bosluk()
        {
            Console.WriteLine();
        }

    }
}
