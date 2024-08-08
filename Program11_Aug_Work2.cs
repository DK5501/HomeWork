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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tMain Menu");
            Console.WriteLine("[1] Baht to Dallra");
            Console.WriteLine("[2] Baht to Yen");
            Console.WriteLine("[3] Baht to Euro");
            Console.WriteLine("[4] Baht to Yuan");
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.Write("Select your choice to change money : ");
            string choice = Console.ReadLine();
            int newchoice = int.Parse(choice);

            if (newchoice == 1)
            {
                Dallra();
            }
            else if (newchoice == 2)
            {
                Yen();
            }
            else if (newchoice == 3)
            {
                Euro();
            }
            else if (newchoice == 4)
            {
                Yuan();
            }
            else
            {
                Console.WriteLine.ForegroundColor = ConsoleColor.DarkMagenta("\tOutput : must only 1 - 4");
            }

            Console.WriteLine("\nPress any key to exit program");
            Console.ReadKey();
        }
        static void Dallra()
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
