﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice die1 = new Dice();
            Dice die2 = new Dice();
            Dice die3 = new Dice();

            Console.WriteLine(die1.FaceValue);
            Console.WriteLine(die2.FaceValue);
            Console.WriteLine(die3.FaceValue);
            Console.ReadKey();
        }
    }
}
