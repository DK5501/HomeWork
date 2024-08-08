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
            List<int> scores = new List<int>();
            while (scores.Count < 3)
            {
                try
                {
                    Console.Write($"input score no.{scores.Count + 1} : ");
                    int score = int.Parse(Console.ReadLine());
                    if (score < 0 || score > 100)
                    {
                        throw new Exception("Invalid input. Please enter a number between 0 and 100.");
                    }
                    scores.Add(score);
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            var result = scores.Sum(x => x);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOutput : ");

            if (result < 220)
            {
                Console.WriteLine($"\n\tTotal score = {result}    You are improved");
            }
            else if (result >= 220 && result < 250)
            {
                var subscore = scores.Where(x => x >= 80).ToList();
                if (subscore.Count > 0 && subscore.Count <= 1)
                {
                    Console.WriteLine($"\n\tTotal score = {result}    You are satisfied");
                }
                else if (subscore.Count == 2)
                {
                    Console.WriteLine($"\n\tTotal score = {result}     You are good");
                }
                else if (subscore.Count == 3)
                {
                    Console.WriteLine($"\n\tTotal score = {result}     You are very good");
                }
            }
            else if (result >= 250)
            {
                Console.WriteLine($"\n\tTotal score = {result}     You are excellent");
            }
            Console.WriteLine("\nPress any key to exit program");
            Console.ReadKey();
        }
    }
}
