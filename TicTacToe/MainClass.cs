using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class MainClass
    {
        // init

        private int numOfGames = 0;

        public static void Main(string[] args)
        {

            // Start -- menu
            BoardGame theBoard = new BoardGame();
            Display theDisplay = new Display(theBoard);
            Console.WriteLine("Enter player one's name");
            String player1 = Console.ReadLine();
            Console.WriteLine("Enter player two's name");
            String player2 = Console.ReadLine();
            Players thePlayers = new Players(player1, player2);

            Boolean game = true;
            //Game
            while (game == true)
            {
                theDisplay.DisplayCurrentBoard();
                Console.WriteLine(thePlayers.GetTurn());
                game = false;
            }

            //Results / go back to staet

            Console.ReadKey(); // prevent console from closing once program is complete
        }
    }
}
