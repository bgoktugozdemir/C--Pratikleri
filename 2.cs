using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct Otomobil
        {
            public string model;
            public int motorHacmi;
            public bool otomatikVites;
            public string renk;
        }

        static void Main(string[] args)
        {
     //       bmw Otomobil = new Otomobil();    //Hata veriyor. Alt satırla aynı
            Otomobil bmw;

            bmw.model = "Tourer";
            bmw.motorHacmi = 2000;
            bmw.otomatikVites = true;
            bmw.renk = "Gümüş";

            Console.WriteLine("Araba Modeli -> {0}\nMotor Hacmi -> {1}\nOtomatik Vites Mi -> {2}\nAraba Renk -> {3}", bmw.model, bmw.motorHacmi, bmw.otomatikVites, bmw.renk);

            string pw;
            Console.Write("\nYönetici Şifrenizi Giriniz: ");
            pw = Console.ReadLine();

            if (pw == "yonetici")
            {
                Console.WriteLine("Hoşgeldin Şef");
            }
            else
            {
                Console.WriteLine("Yanlış Şifre!");
            }
        }
    }

}
