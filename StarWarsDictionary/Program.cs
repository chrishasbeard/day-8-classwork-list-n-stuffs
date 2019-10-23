using System;
using System.Collections.Generic;

namespace StarWarsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> starWarsCharacters = new Dictionary<string, bool>
            {
                {"Anakin Skywalker", true},
                { "Obi Wan Kenobi", false},
                { "Frodo", false},
                { "R2D2", false},
                { "Darth Maul", true},
                {"yoda", true }
            };
            starWarsCharacters.Add("Han Solo", false);
            starWarsCharacters.Add("Ben Solo", true);
            foreach(KeyValuePair<string, bool> kvp in starWarsCharacters)
            {
                PrintCharacters(kvp);
            }
        }

        public static void PrintCharacters(KeyValuePair<string, bool> character)
        {
            if(character.Value)
            {
                Console.WriteLine($"{character.Key} has the force.");
            }
            else
            {
                Console.WriteLine($"{character.Key} does not have the force.");
            }
        }
    }
}
