using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal class Phrases
    {   
        public static string CongratPhrases () 
        {
            Random rnd = new Random ();

            string[] CongratPhrases = 
            {
                "-You have defeated a terrible Monster! Congratulations!! ",
                "-It was incredible!! Now The KingDOS is safe!",
                "-You won and deserve a reward! All ale in the kingDOS is Yours!"
            };

            return (CongratPhrases[rnd.Next(0, 3)]);
        }
        public static string MotivationalPhrases () 
        {
            Random rnd = new Random ();

            string[] MotivationalPhrases = 
            {
                "-You lost this battle. But not THE WAR!",
                "-You can do it! The whole KingDOS relies on you!",
                "-This time you`ve been defeated. But it`s not time to give up, You have to beat the VIRUSTER!"
            };

            return (MotivationalPhrases[rnd.Next(0, 3)]);
        }
    }
}
