using System;
using System.Collections.Generic;

namespace afternoon_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
        }
        public static int FindMin(List<int> numbers)
        {
            int smallest = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < smallest)
                {
                    samllest = numbers[i];
                }
            }
            return smallest;
        }

        public static string ReverseString(string element)
        {
            //char[] broken = element.ToCharArray();
            List<char> reformed = new List<char>();
            for (int i = element.Length - 1; i >= 0; i--)
            {
                reformed.Add(element[i]);
            }

            return reformed.ToString();
        }

        public static List<int> IsDivisibleBy(List<int> numbers, int number)
        {
            List<int> numbers2 = new List<int>();
            foreach (int item in numbers)
            {
                if (item %number == 0)
                {
                    numbers2.Add(item);               
                }
            }
            return numbers2;
        }
    }
}
