using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class SetUp
    {
        BoardGame theBoard;
        Display theDisplay;
        Players thePlayers;
        CheckWinner checkWin;
        NewGame theOption;

        public SetUp()
        {
            // Start -- menu
            theBoard = new BoardGame();
            theDisplay = new Display(theBoard);
            Console.WriteLine("Enter player one's name");
            String player1 = Console.ReadLine();
            Console.WriteLine("Enter player two's name");
            String player2 = Console.ReadLine();
            thePlayers = new Players(player1, player2);
            checkWin = new CheckWinner();
            theOption = new NewGame();

        }

        // getters

        public BoardGame getBoard()
        {
            return theBoard;
        }

        public Display getDisplay()
        {
            return theDisplay;
        }

        public Players getPlayers()
        {
            return thePlayers;
        }

        public CheckWinner getCheckWin()
        {
            return checkWin;
        }

        public NewGame getOption()
        {
            return theOption;
        }

    }
}
