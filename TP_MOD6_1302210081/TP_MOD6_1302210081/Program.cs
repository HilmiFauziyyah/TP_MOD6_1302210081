using System;

namespace TP_MOD6_1302210081
{
    class Program
    {
        static void Main(string[] args)

        {
            SayaTubeVideo saya = new SayaTubeVideo(" Tutorial Design By Contract - Hilmi Fauziyyah S ");

            saya.IncreasePlayCount(0);

            saya.PrintVideoDetails();

            Console.WriteLine();

            SayaTubeVideo saya1 = new SayaTubeVideo(" Hilmi Fauziyyah S");

            saya1.IncreasePlayCount(1000000000);

            saya1.PrintVideoDetails();
        }
    }
}

