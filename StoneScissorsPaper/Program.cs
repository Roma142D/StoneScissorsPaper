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

            bool wrongWeapon;
            int trys = 0;
            int wins = 0;
            string playerWeapon;
            string readyOrNot;
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
                return;
            }
            else
            {
                Console.WriteLine($"-OK,{playerName}! Here`s your hero journal: \n Name:{playerName} \n Age:{playerAge} \n" +
                    $" Attempts to win:{trys} \n Victories:{wins}");
            }

            Console.Write($"\n-It`s time to begin your journey! Are you ready,{playerName}? \n-");

            do
            {
                Console.Write("-Plese answer just 'Yes' or 'No'\n-");
                readyOrNot = Console.ReadLine().ToLower();


            } while (readyOrNot != "yes" && readyOrNot != "no");
            
            
            if (readyOrNot == "no")
            {
                Console.WriteLine($"-Then come back when you will be ready! See you later, {playerName}!");
                return;
            }

            
            
            Console.WriteLine($"\n-Unfortunately VIRUSTER destroyed all our mighty artifacts.\n" +
                $" So you have to choose among these three items:\n-{Weapon.Stone}\n{Graphics.ImgStone()}\n" +
                $"-{Weapon.Scissors}\n{Graphics.ImgScissors()}\n-{Weapon.Paper}\n{Graphics.ImgPaper()}\n\n" +
                $"-There is also good news. VIRUSTER uses the same weapons, so your chances are equal.\n" +
                $" And remember one thing:\n " +
                $" !'STONE>SCISSORS>PAPER>STONE'!");

            
            do
            {
                Console.Write("\n-Say the name of the selected weapon\n-");
                playerWeapon = Console.ReadLine().ToLower();
                wrongWeapon = playerWeapon != "stone" && playerWeapon != "scissors" && playerWeapon != "paper";

                if (wrongWeapon)
                {
                    Console.WriteLine("-We have only three things to choose from:\n-Stone\n-Scissors\n-Paper");
                }
            } 
            while (wrongWeapon);

            switch ( playerWeapon )
            {
                case "stone":
                    playerWeapon = (Weapon.Stone).ToString();
                    break;
                case "scissors":
                    playerWeapon = (Weapon.Scissors).ToString();
                    break;
                case "paper":
                    playerWeapon = (Weapon.Paper).ToString();
                    break;
            }



            Console.WriteLine(playerWeapon);

            
            


        }
    }	
}
