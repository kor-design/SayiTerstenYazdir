using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTerstenYaz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int tersten_sayi = 0;
                var Fsayi = sayi;
                do
                {
                    tersten_sayi = tersten_sayi * 10; // bir sonraki basmağı sıfır yapıp sayıdan gelen basamağı eklemek için(3)
                    tersten_sayi = tersten_sayi + sayi % 10; //sayının bir basamağını başa almak için (1)
                    sayi = sayi / 10; // sayının birler basamaığından kurtulmak için (2)
                } while (sayi!=0);
                Console.WriteLine("({0}) sayısının tersten yazlışı; \n({1}) şeklindedir",Fsayi,tersten_sayi);
                Console.Read();
            }
        }
    }
}
