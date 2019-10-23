using System;
using System.Collections.Generic;

namespace whiteboard_prob
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>
            {
                {"apple" },
                {"orange" },
                {"cherry" }
            };
            Console.WriteLine(fruits[2]);
            Console.WriteLine("Add a fruit, please.");
            fruits.Add(Console.ReadLine());

            foreach (string word in fruits)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}
