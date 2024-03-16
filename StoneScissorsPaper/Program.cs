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
            int healthMonster = 2;
            int healthPlayer = 2;
            string playerWeapon;
            Weapons monsterWeapon;
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

            Console.Write($"\n-It`s time to begin your journey! Are you ready,{playerName}?\n");

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
                $" So you have to choose among these three items:\n-{Weapons.Stone}\n{Graphics.ImgStone()}\n" +
                $"-{Weapons.Scissors}\n{Graphics.ImgScissors()}\n-{Weapons.Paper}\n{Graphics.ImgPaper()}\n\n" +
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
                    playerWeapon = (Weapons.Stone).ToString();
                    break;
                case "scissors":
                    playerWeapon = (Weapons.Scissors).ToString();
                    break;
                case "paper":
                    playerWeapon = (Weapons.Paper).ToString();
                    break;
            }

            Console.WriteLine($"\nNow you are armed with {playerWeapon} and ready to go.\n" +
                              $"Just outside the castle walls you meet a VIRUSTER\n{Graphics.ImgMonster()}");

                        
            for (;healthMonster!=0 && healthPlayer != 0;)
            {
                Random rnd = new Random();
                int randomWeapon = rnd.Next(0, 3);
                monsterWeapon = (Weapons)randomWeapon;

                if (monsterWeapon == Weapons.Stone && playerWeapon == "Scissors") 
                {
                    healthPlayer -= 1;
                    Console.WriteLine("You take damage!");
                }
                else if (monsterWeapon == Weapons.Stone && playerWeapon == "Paper") 
                {
                    healthMonster -= 1;
                    Console.WriteLine("VIRUSTER takes damage!");
                }
                else if (monsterWeapon == Weapons.Scissors && playerWeapon == "Paper") 
                {
                    healthPlayer -= 1;
                    Console.WriteLine("You take damage!");
                }
                else if (monsterWeapon == Weapons.Scissors && playerWeapon == "Stone") 
                {
                    healthMonster -= 1;
                    Console.WriteLine("VIRUSTER takes damage!");
                }
                else if (monsterWeapon == Weapons.Paper && playerWeapon == "Stone")
                {
                    healthPlayer -= 1;
                    Console.WriteLine("You take damage!");
                }
                else if (monsterWeapon == Weapons.Paper && playerWeapon == "Scissors")
                {
                    healthMonster -= 1;
                    Console.WriteLine("VIRUSTER takes damage!");
                }
                else
                {
                    Console.WriteLine("You both miss");
                   
                }

            }
            trys++;
            Console.WriteLine($"Trys:{trys}");
            Console.WriteLine($"Monster{healthMonster}  Player{healthPlayer}");




            
            


        }
    }	
}
