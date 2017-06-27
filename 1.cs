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
            //Pi Sabiti
            const double pi = 3.14159;

            //Alan, Cevre, Yaricap Degiskeni
            double alan, cevre, yaricap;
            string yaricapGir;

            Console.WriteLine("Daire'nin Yaricapini Giriniz: "); //Ekrana Yaz
            yaricapGir = Console.ReadLine();    //Kullanıcıdan girdi al
            yaricap = Convert.ToDouble(yaricapGir);
            cevre = 2 * pi * yaricap;
            alan = pi * yaricap * yaricap;
            Console.WriteLine("Daire'nin Alani = {0}", alan); // {0} -> Virgülden sonraki 0. elemanı yaz.
            Console.WriteLine("Daire'nin Cevresi = {0}", cevre);

            Console.WriteLine("Dairenin Alani = {0} \nDaire'nin Çevresi = {1}", alan, cevre);

            var isim = "Goktug";
            Console.WriteLine(isim.GetType());
        }
    }

}
