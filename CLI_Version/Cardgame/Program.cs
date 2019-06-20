using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame
{
    class Program
    {

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            //Create Game
            Game Game = new Game();
            Game.GameRun();

            //End of Game
            bool Reset = false;
            while (!Reset)
            {
                Console.WriteLine("End of this game, Thanks for playing!\n");
                Console.WriteLine("Do you want to play again? [Y/N]?");
                string Choice = Console.ReadLine();
                Choice = Choice.ToLower();
                if (Choice == "y")
                {
                    Reset = true;
                }
                else if (Choice == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Input invalid, try again: \n");
                }
            }
            Main();
        }
    }
}
