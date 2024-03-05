using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Class for testing the Game and Die classes.
    /// </summary>
    internal class Testing
    {
        Game GameTest = new Game();
        Die DieTest = new Die();

        /// <summary>
        /// Method to test the Die class by checking the roll and die value.
        /// </summary>
        public void TestDieClass()
        {
            Debug.Assert(DieTest.Roll >= 1 && DieTest.Roll <= 6, "The data type is incorrect or out of range (DieRoll)");
            Debug.Assert(DieTest.DieValue >= 1 && DieTest.Roll <= 6, "The data type is incorrect or out of range (DieValue)");
        }

        /// <summary>
        /// Method to test the Game class by checking various properties.
        /// </summary>
        public void TestGameClass()
        {
            Debug.Assert(GameTest.DieSum == GameTest.Die_D1 + GameTest.Die_D2 + GameTest.Die_D3, "Maths Error (DieSum)");
            Debug.Assert(GameTest.Rounds >= 0, "Logic error (GameRound)");
            Debug.Assert(GameTest.Die_D1 >= 0 && GameTest.Die_D1 <= 6, "Return valid not in range or incorrect data type (Die_D1)");
            Debug.Assert(GameTest.Die_D2 >= 0 && GameTest.Die_D2 <= 6, "Return valid not in range or incorrect data type (Die_D2)");
            Debug.Assert(GameTest.Die_D3 >= 0 && GameTest.Die_D3 <= 6, "Return valid not in range or incorrect data type (Die_D3)");
        }
    }
}