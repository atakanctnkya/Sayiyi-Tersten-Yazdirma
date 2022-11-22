using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayıyı_tersten_yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int sayi, sayininTersi=0, asilSAyi;
                Console.Write("Lütfen bir sayı giriniz = ");
                sayi = int.Parse(Console.ReadLine());
                asilSAyi = sayi;

                while (sayi != 0)
                {
                    sayininTersi = sayininTersi * 10;
                    sayininTersi = sayininTersi + sayi % 10;
                    sayi = sayi / 10;
                }

                Console.WriteLine("{0} sayısının tersi = {1}\n", asilSAyi, sayininTersi);
            }



        }
    }
}
