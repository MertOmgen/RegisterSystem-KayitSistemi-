using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Örnek_6
{
    class Hastalar
    {
        private string isim = string.Empty;
        private int id = default(int);
        private int adet = default(int);
        private bool idgiris = default(bool);
        private bool isimgiris = default(bool);

        public Hastalar()
        {
            try
            {
                Console.Write("Kaç Adet Hasta Girilecek : ");
                adet = Convert.ToInt32(Console.ReadLine());
                Bosluk();

                var regexItem = new Regex("^[a-zA-Z\x20]*$");

                Dictionary<int, string> _Hastalar = new Dictionary<int, string>();

                do
                {

                    for (int i = 0; i < adet; i++)
                    {
                        if (idgiris == false)
                        {
                            Console.Write("Hasta ID'sini Belirtin : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Bosluk();
                            idgiris = true;
                        }
                        if (isimgiris == false)
                        {
                            Console.Write("Hasta İsmini Yazınız : ");
                            isim = Console.ReadLine();
                            Bosluk();
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
                        _Hastalar.Add(id, isim);
                    }

                } while (!regexItem.IsMatch(isim));

                Bosluk();
                foreach (var hasta in _Hastalar)
                {
                    Console.WriteLine(hasta);
                }
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
