using System;

namespace Day_8_class_work_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "dog", "cat", "snake", "hamster", "goldfish", "goldfish" };
            bool found = FindElement(animals, "cat");          
            if (!found)
            {
                animals[0] = "cat";
            }

           

            //foreach (string word in animals)
            //{
            //    if (word == "cat")
            //    {
            //        Console.WriteLine("I FOUND A KITTY ");
            //    }
            //}
        }

        public static bool FindElement(string[] array, string element)
        {
            foreach (string word in array)
            {
                if (word == element)
                {
                    Console.WriteLine($"{ element}");
                    return true;
                }
            }
            return false;
        }
    }
}
