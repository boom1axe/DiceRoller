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

        /// <summary>
        /// rolls die and sets face value to generated number
        /// and returns generated number
        /// </summary>
        /// <returns></returns>
        public byte Roll()
        {
            const byte MinValue = 1;

            //offset because of exclusive upper bound for random
            byte Maxvalue = (byte)(numbersOfSides + 1);

            Random rand = new Random();
            byte result = (byte)rand.Next(1, numbersOfSides + 1);

            faceValue = result;

            return result;
        }
    }
}
