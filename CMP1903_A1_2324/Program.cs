using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1903_A1_2324;



namespace CMP1903_A1_2324
{
    /// <summary>
    /// Represents a menu system allowing users to interact with the game and testing functionalities.
    /// </summary>
    static void Menu()
    {
        int UserChoice;
        Game game = new Game(); // creates game class
        Testing testing = new Testing(); // creates testing class

        // Loop to display the menu until the user makes a valid choice
        while (true)
        {
            try
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Welcome: \nChoice based on corresponding number. \n1- Play Game: \n2- Test Game:\n3- Exit: ");
                Console.WriteLine("--------------------");

                // Read user input for menu choice
                UserChoice = Convert.ToInt32(Console.ReadLine());

                // Check if user input is within valid range
                if (UserChoice >= 1 && UserChoice <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Input ({UserChoice}) out of range!!!!");
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input!!!!");
            }
        }

        // Perform actions based on user choice
        if (UserChoice == 1)
        {
            // Play the game
            Console.WriteLine($"Round: {game.Rounds}");
            game.GameRoll();
            Console.WriteLine($"Round total :{game.DieSum}");
            Console.WriteLine($"Combined Total :{game.CombinedTotal} \n");

            // Loop to allow continuous rolling if desired by the user
            while (true)
            {
                try
                {
                    Console.WriteLine("Would you like to roll again? (1 = continue 2 = Menu )");
                    UserChoice = Convert.ToInt32(Console.ReadLine());
                    if (UserChoice == 1)
                    {
                        game.AddRounds++;
                        Console.WriteLine($"\nRound: {game.Rounds}");
                        game.GameRoll();
                        Console.WriteLine($"Round total :{game.DieSum}");
                        Console.WriteLine($"Combined Total :{game.CombinedTotal} \n--------------------");
                        continue;
                    }
                    else if (UserChoice == 2)
                    {
                        // Go back to the main menu
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine($"Input ({UserChoice}) out of range!!!!");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input!!!!\n");
                }
            }
        }
        else if (UserChoice == 2)
        {
            // Test the game functionality
            Console.WriteLine("--------------------\nTESTING");
            testing.TestDieClass();
            testing.TestGameClass();
            Console.WriteLine("End of Testing");
            Menu(); // Go back to the main menu
        }
        else if (UserChoice == 3)
        {
            // Exit the program
            Environment.Exit(0);
        }
    }

    // Start the menu system
    Menu();
}

   