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
          int bakiye = 1000;

            Console.WriteLine("Atm'ye hoşgeldiniz");

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz..");
            Console.WriteLine("1:Bakiye Görüntüle");
            Console.WriteLine("2:Para çek");
            Console.WriteLine("3:Para yatır");
            Console.WriteLine("4:Çıkış yap");
            string secim = Console.ReadLine();

            switch(secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz: "+ bakiye);
                    break;
                case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                    string tutar = Console.ReadLine();
                    int tutarInt = Convert.ToInt32(tutar);

                    Console.WriteLine("Para çekilmiştir.Yeni bakiyeniz: " + (bakiye - tutarInt));
                    break;
                case "3":
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                    string tutar2 = Console.ReadLine();
                    int tutar2Int = Convert.ToInt32(tutar2);
                    Console.WriteLine("Para yatırılmıştr.Yeni tutarınız: "+ (bakiye + tutar2Int));
                    break;
                case "4":
                    Console.WriteLine("Çıkış yapılıyor..");
                    break;

            }
            Console.ReadLine();
            
            
        }
    }
}
