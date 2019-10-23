using System;
using System.Collections.Generic;

namespace FillListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sportsTeam = new List<string>();

            bool addPlayers = true;

            while (addPlayers)
            {
                AddToList(sportsTeam);
                Console.WriteLine("Add more more sports ballers?");
                string input = Console.ReadLine().ToLower();
                if(input == "no")
                {
                    addPlayers = false;
                }
            }
            
            for(int i = 0; i< sportsTeam.Count; i++)
            {
                Console.WriteLine($"{sportsTeam[i]}");
            }
        }

        public static void AddToList(List<string> sportsPeople)
        {
            Console.WriteLine("Please enter a name of a sports baller");
            string player = Console.ReadLine();
            sportsPeople.Add(player);
        }
    }

}
