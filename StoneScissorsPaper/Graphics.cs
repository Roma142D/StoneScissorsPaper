﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal class Graphics
    {
        public static void BuildCastle()
        {
            char a = '┐';
            char b = '├';
            char c = '┤';
            char d = '┌';
            char e = (char)92;
            char f = '─';
            Console.WriteLine($"             /{e}             \n" +
                              $"            /  {e}            \n" +
                              $"      /{e}   /    {e}   /{e}    \n" +
                              $"     /  {e}  {b}{f}{f}{f}{f}{c}  /  {e} \n" +
                              $"    /    {e} | {d}{a} | /    {e}  \n" +
                              $"    {b}{f}{f}{f}{f}{c} | || | {b}{f}{f}{f}{f}{c} \n" +
                              $"    |    | | || | |    | \n" +
                              $"    |    | | {b}{c} | |    | \n" +
                              $" {d}{c} |    | |    | |    | {b}{a} \n" +
                              $" {b}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{f}{c} \n" +
                              $" {b}{a}______________________{d}{c}\n" +
                              $"  |        WELCOME       |\n" +
                              $"  |    to the kingDOS    | \n" +
                              $"  |          /{e}          | \n" +
                              $"  |         /  {e}         | \n" +
                              $"  |         |  |         | \n" +
                              $"{f}{f}|         |  |         |{f}{f}");
        }
    }
}