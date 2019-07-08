using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// Repersents a single
    /// multi-sided die
    /// </summary>
    class Dice
    {
        private byte faceValue;
        private bool isHeld;
        private byte numbersOfSides;
        private static Random rand;

        static Dice()
        {
            // Static allows sharing on instance of Random across
            // instances of 
            rand = new Random();
        }

        /// <summary>
        /// Creates a standard 6-sided die
        /// </summary>
        public Dice() : this(6)
        {

        }

        public Dice(byte numberOfSides)
        {
            this.numbersOfSides = numbersOfSides;
            Roll();
        }

        public byte FaceValue
        {
            get { return faceValue; }
            private set
            {
                if (value == 0)
                    throw new Exception("Dice cannot be 0");
                FaceValue = value;
            }
        }

        public bool IsHeld { get; set; }

        /// <summary>
        /// rolls die and sets face value to generated number
        /// and returns generated number
        /// </summary>
        /// <returns></returns>
        public byte Roll()
        {

            if (isHeld)
            {
                return FaceValue;
            }

            const byte MinValue = 1;

            //offset because of exclusive upper bound for random
            byte MaxValue = (byte)(numbersOfSides + 1);

            Random rand = new Random();
            byte result = (byte)rand.Next(MinValue, MaxValue);

            faceValue = result;

            return result;
        }


    }
}
