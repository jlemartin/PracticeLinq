using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a list of video games.
            var gameList = new List<string>();
            gameList.Add("Space Invaders");
            gameList.Add("Legend of Zelda");
            gameList.Add("Pong");
            gameList.Add("Ocarina of Time");
            gameList.Add("Maniac Mansion");

            Console.WriteLine("----------------------------");
            // 2. List games by the length of the game name *
            var byLength = gameList.OrderBy(name => name.Length);

            foreach (var n in byLength)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("--------------------------------");
            // 3. Order by length of the game name *
            var reverseOrder = gameList.OrderByDescending(name => name.Length);

            foreach (var n in reverseOrder)
            {
                Console.WriteLine(n);
            }

            // * Using the Lambda expression

            Console.WriteLine("--------------------------------");
            // For fun: alphabetical listing
            var alphaList = gameList.OrderBy(n => n);

            foreach (var n in alphaList)
            {
                Console.WriteLine(n);
            }


        }
    }
}
