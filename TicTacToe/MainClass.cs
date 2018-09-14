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
            CheckWinner checkWin = new CheckWinner();

            Boolean game = true;
            int position;
            CurrentStateOnBoard turn;
            //Game
            // BUG: keeps changing turn's even if player entered valid input
            while (game == true)
            {
                theDisplay.DisplayCurrentBoard();
                Console.WriteLine($"It is player {thePlayers.GetTurn()}'s turn");
                Console.WriteLine("Enter move");
                position = Convert.ToInt32(Console.ReadLine());

                // account for valid moves
                while((position < 1) || (position > 9) || (theBoard.GetPositionState(position) != CurrentStateOnBoard.Empty))
                {
                    Console.WriteLine("Invalid, Re-enter move");
                    position = Convert.ToInt32(Console.ReadLine());

                }

                theBoard.AddtoBoard(position, thePlayers.GetTurn());
                turn = checkWin.CheckForWinner(position, theBoard);
                if (turn != CurrentStateOnBoard.Empty)
                {
                    Console.WriteLine($"Player {turn}'s wins!");
                    game = false;
                }
                //theDisplay.DisplayCurrentBoard();
                // Clarity on who goes
                thePlayers.Turn();
               // Console.WriteLine($"It is player {thePlayers.Turn()}'s turn");
            }

            //Results / go back to staet

            Console.ReadKey(); // prevent console from closing once program is complete
        }
    }
}
