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
            byte Ay = Convert.ToByte(Console.ReadLine());

            if (Ay == 1)
            {
                Console.WriteLine("Ocak");
            }
            else if (Ay == 2)
            {
                Console.WriteLine("Şubat");
            }
            else if (Ay == 3)
            {
                Console.WriteLine("Mart");
            }
            else if (Ay == 4)
            {
                Console.WriteLine("Nisan");
            }
            else if (Ay == 5)
            {
                Console.WriteLine("Mayıs");
            }
            else if (Ay == 6)
            {
                Console.WriteLine("Haziran");
            }
            else if (Ay == 7)
            {
                Console.WriteLine("Temmuz");
            }
            else if (Ay == 8)
            {
                Console.WriteLine("Ağustos");
            }
            else if (Ay == 9)
            {
                Console.WriteLine("Eylül");
            }
            else if (Ay == 10)
            {
                Console.WriteLine("Ekim");
            }
            else if (Ay == 11)
            {
                Console.WriteLine("Kasım");
            }
            else if (Ay == 12)
            {
                Console.WriteLine("Aralık");
            }
            else
            {
                Console.WriteLine("1-12 arasında bir sayı girmelisiniz.");
            }
        }
    }
}
