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
            Console.Write("input type : ");
            char type = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("price : ");
            double price = double.Parse(Console.ReadLine());
            double discount = 0;

            discount = Calculator(type, price);

            Console.WriteLine("\nOutput");
            Console.WriteLine($"\tCustomer type : General ");
            Console.WriteLine($"\tPrice : {price}");
            Console.WriteLine($"\tDiscount : {discount}");
            Console.WriteLine($"\tNet price : {price - discount}");

            Console.WriteLine("\nPress any key to exit program");
            Console.ReadKey();
        }

        static int Calculator(string type, ,int price)
        {
            if(type == "G")
            {
                if(price > 30000)
                {
                    return price * 0.05;
                }else if (price >= 10000)
                {
                    return price * 0.03
                }
            }
            else if (type == 'V')
            {
                if (price > 30000)
                {
                    return price * 0.10;
                }
                else
                {
                    return price * 0.05;
                }
            }
            else
            {
                Console.WriteLine("\t\nHave two choice (G and V)");
            }

            return 0;
        }
    }
}
