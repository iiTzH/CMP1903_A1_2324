using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{

    /// <summary> Represents a die with a certain value that can be rolled to generate a random value./// </summary>

    internal class Die
    {

        /// <summary> The current value of the die./// </summary>

        private int _value;


        /// <summary> Random number generator used for rolling the die./// </summary>

        Random rand = new Random();


        /// <summary> Rolls the die and returns the result./// </summary>

        /// <returns>An integer representing the rolled value of the die.</returns>
        public int Roll
        {
            get { return _value = rand.Next(1, 7); }
        }


        /// <summary>Gets the current value of the die. /// </summary>

        public int DieValue
        {
            get { return _value; }
        }
    }
}
