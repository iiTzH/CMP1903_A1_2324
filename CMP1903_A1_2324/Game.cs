using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Represents a game that involves rolling three dice and calculating their sum.
    /// </summary>
    internal class Game
    {
        // creates dice objects / properties
        private int _total;


        private int _round = 1;
        Die D1 = new Die();
        Die D2 = new Die();
        Die D3 = new Die();

        //-----------------------------------------------------

        /// <summary>
        /// Rolls the three dice and displays their values.
        /// </summary>

        public int Total
        {
            get { return _total; }

        }


        public void GameRoll()
        {
            Console.WriteLine($"Die1 = {D1.Roll}: \nDie2 = {D2.Roll}: \nDie3 = {D3.Roll}:  ");
        }

        /// <summary>
        /// Calculates the sum of the values of the three dice.
        /// </summary>
        public int CombinedTotal
        {

            get { return _total += D1.DieValue + D2.DieValue + D3.DieValue; }

        }


        //-----------------------------------------------------

        /// <summary>
        /// Adds a round to the game.
        /// </summary>
        public int AddRounds
        {
            set { _round++; }
            get { return _round; }
        }

        /// <summary>
        /// Gets the current round of the game.
        /// </summary>
        public int Rounds
        {
            get { return _round; }
        }

        /// <summary>
        /// Calculates the total value of the dice in the current round.
        /// </summary>
        public int DieSum
        {
            get { return D1.DieValue + D2.DieValue + D3.DieValue; }
        }

        //-----------------------------------------------------

        /// <summary>
        /// Gets the value of the first die.
        /// </summary>
        public int Die_D1
        {
            get { return D1.DieValue; }
        }

        /// <summary>
        /// Gets the value of the second die.
        /// </summary>
        public int Die_D2
        {
            get { return D2.DieValue; }
        }

        /// <summary>
        /// Gets the value of the third die.
        /// </summary>
        public int Die_D3
        {
            get { return D3.DieValue; }
        }

        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continuous, and the totals and other statistics could be summarized for example( Total rolls , Total sum, Round sum).
         */

        //Method

    }
}