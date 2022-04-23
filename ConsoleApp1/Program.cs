using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1.notunuzu giriniz");
            string not1 = Console.ReadLine();
            Console.WriteLine("Lütfen 2.notunuzu giriniz");
            string not2 = Console.ReadLine();
            Console.WriteLine("Lütfen 3.notunuzu giriniz");
            string not3 = Console.ReadLine();

            int not1Int = Convert.ToInt32(not1);
            int not2Int = Convert.ToInt32(not2);
            int not3Int = Convert.ToInt32(not3);
            int ortalama = (not1Int + not2Int + not3Int) / 3;
            
            if (ortalama < 100 && ortalama > 80)
            {
                Console.WriteLine("A+");
            }
            else if (ortalama < 80 && ortalama > 60)
            {
                Console.WriteLine("A");
            }
            else if (ortalama < 60 && ortalama > 40)
            {
                Console.WriteLine("B+");
            }
            else
            {
                Console.WriteLine("F");
            }

            Console.ReadLine();
            
            
        }
    }
}
