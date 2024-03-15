using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trys = 0;
            int wins = 0;
            Graphics.BuildCastle();

            Console.WriteLine("-Greetings! Have you come to defeat the VIRUSTER?");
            Console.Write("-So, what is your name, hero? \n-");
            var playerName = Console.ReadLine();
            Console.Write("-How old are you? \n-");
            var playerAge = int.Parse(Console.ReadLine());

            if (playerAge < 12 ) 
            {
                Console.WriteLine("-Sorry, you`re too young to defeat the VIRUSTER! \n" +
                    "-Come back when you get older.");
            }
            else
            {
                Console.WriteLine($"-OK,{playerName}! Here`s your hero journal: \n Name:{playerName} \n Age:{playerAge} \n" +
                    $" Attempts to win:{trys} \n Victories:{wins}");
            }

            Console.Write($"\n-It`s time to begin your journey! Are you ready,{playerName}? \n-");
            var readyOrNot = Console.ReadLine().ToLower();

            


        }
    }	
}
