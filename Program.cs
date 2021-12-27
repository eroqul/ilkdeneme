using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_denemem
{
    class Program
    {
        static void Main(string[] args)
        {
            string durum;
            int yas;
            Console.WriteLine("Merhaba");

            Console.WriteLine("Adınızı Gir Lan");

           string ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı Gir Lan");
            string soyad = Console.ReadLine();

            Console.WriteLine("SELAM " + ad + " " + soyad);

            Console.WriteLine("nasılsın");

            durum = Console.ReadLine();

            Console.WriteLine("yaşın");

            yas = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
