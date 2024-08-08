using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_Aug_Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tMain Menu");
            Console.WriteLine("[1] Baht to Dollra");
            Console.WriteLine("[2] Baht to Yen");
            Console.WriteLine("[3] Baht to Euro");
            Console.WriteLine("[4] Baht to Yuan");
            Console.Write("Select your choice to change money : ");
            string choice = Console.ReadLine();
            int newchoice = int.Parse(choice);

            switch (newchoice)
            {
                case 1:
                    Dollra();
                    break;
                case 2:
                    Yen();
                    break;
                case 3:
                    Euro();
                    break;
                case 4:
                    Yuan();
                    break;
                default:
                    Console.WriteLine("\tOutput: must only be 1 - 4");
                    break;
            }

            Console.WriteLine("\nPress any key to exit program");
            Console.ReadKey();
        }
        static void Dollra()
        {
            Console.Write("Money (Thai) : ");
            var t = Console.ReadLine();
            double result = 0;
            try
            {
                result = float.Parse(t) / 36.37;
            }
            catch
            {
                Console.WriteLine("Incorrect number");
                return;
            }
            Console.WriteLine($"\nOutput :");
            Console.WriteLine($"\tYou chose baht to Dollar");
            Console.WriteLine($"\t{t} baht = {result:f} dollar rate = 36.37/dollar");
        }
        static void Yen()
        {
            Console.Write("Money (Thai) : ");
            var t = Console.ReadLine();
            double result = 0;
            try
            {
                result = float.Parse(t) / 0.281;
            }
            catch
            {
                Console.WriteLine("Incorrect number");
                return;
            }
            Console.WriteLine($"\nOutput :");
            Console.WriteLine($"\tYou chose baht to Yen");
            Console.WriteLine($"\t{t} baht = {result:f} yen rate =0.281/yen");
        }
        static void Euro()
        {
            Console.Write("Money (Thai) : ");
            var t = Console.ReadLine();
            double result = 0;
            try
            {
                result = float.Parse(t) / 37.58;
            }
            catch
            {
                Console.WriteLine("Incorrect number");
                return;
            }
            Console.WriteLine($"\nOutput :");
            Console.WriteLine($"\tYou chose baht to Euro");
            Console.WriteLine($"\t{t} baht = {result:f} euro rate = 37.58/euro");
        }
        static void Yuan()
        {
            Console.Write("Money (Thai) : ");
            var t = Console.ReadLine();
            double result = 0;
            try
            {
                result = float.Parse(t) / 4.95;
            }
            catch
            {
                Console.WriteLine("Incorrect number");
                return;
            }
            Console.WriteLine($"\nOutput :");
            Console.WriteLine($"\tYou chose baht to Yuan");
            Console.WriteLine($"\t{t} baht = {result:f} yuan rate = 4.95/yuan");
        }
    }
}
