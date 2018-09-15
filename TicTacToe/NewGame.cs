using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class NewGame
    {
        // If we add multi-number of games we should have a constructor
        // here so we can increment it

        public void PlayNewGame()
        {
            Console.WriteLine("Would you like to play a new game? Y/N");
            String answer = Console.ReadLine();
            while (answer != "Y" && answer != "N")
            {
                Console.WriteLine("Invalid, re-enter Y or N");
                answer = Console.ReadLine();
            }
            if (answer == "Y")
            {
                MainClass m = new MainClass();
                m.Start();
            }
            else
                Console.ReadKey();

        }

    }
}
