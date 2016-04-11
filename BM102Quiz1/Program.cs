using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM102Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Heureux heureux = new Heureux();
            Console.WriteLine("Bir sayı giriniz: ");
            heureux.Number = Convert.ToInt32(Console.ReadLine());
            if (heureux.hesapla())
            {
                Console.WriteLine("Girilen sayı Heureux Sayısıdır :)");
            }
            else Console.WriteLine("Girilen sayı Heureux Sayısı değildir :(");
        }
    }
}
