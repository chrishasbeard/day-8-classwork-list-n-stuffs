using System;
using System.Collections.Generic;

namespace Whiteboard_prob_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            NumberValidation(numbers);
            Console.WriteLine(numbers.Count);
        }

        public static List<int> NumberValidation(List<int> YourNumbers)
        {
            for (int i =0; i<=4;i++)
            {
                Console.WriteLine("Please give me a number divisible by 5.");
                string userNumber = Console.ReadLine();
                int number = int.Parse(userNumber);
                if (number % 5 != 0)
                {
                    Console.WriteLine("startover, you messed up!");
                    return NumberValidation(YourNumbers);                    
                }
               YourNumbers.Add(number);
                               
            }
            return YourNumbers;
            
        }
    }
}
