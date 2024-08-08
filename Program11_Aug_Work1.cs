using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_Aug_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input number2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input number3: ");
            int num3 = int.Parse(Console.ReadLine());
            int Maxnum;

            if (num1 >= num2 && num1 >= num3)
            {
                Maxnum = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Maxnum = num2;
            }
            else
            {
                Maxnum = num3;
            }
            Console.WriteLine("Output :");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tMaximum Number is " + Maxnum);

            Console.WriteLine("\nPress any ley to exit program");
            Console.ReadKey();
        }
    }
}
