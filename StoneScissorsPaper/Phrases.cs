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

            return (CongratPhrases[rnd.Next(0, CongratPhrases.Length)]);
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

            return (MotivationalPhrases[rnd.Next(0, MotivationalPhrases.Length)]);
        }
        public static string QuestionAfterWin() 
        {
            Random rnd = new Random ();

            string[] Questions =
            {
                "\n-Now if you want, you can go back and beat VIRUSTER one more time!\n-Do you want?",
                "\n-Just say 'Yes' if you want to destroy VIRUSTER again (>_0) !"
            };

            return (Questions[rnd.Next(0, Questions.Length)]);
        }
        public static string QuestionAfterLoss() 
        {
            Random rnd = new Random ();

            string[] Questions =
            {
                "\n-Want to try again?",
                "\n-Wanna do it again with another weapon? Just say 'Yes'",
                "\n-Let`s try again! Are you ready?"
            };

            return (Questions[rnd.Next(0, Questions.Length)]);
        }
    }
}
