using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BoardGame theBoard = new BoardGame();
            theBoard.AddtoBoard(1, CurrentStateOnBoard.X);
            theBoard.AddtoBoard(5, CurrentStateOnBoard.X);
            theBoard.AddtoBoard(9, CurrentStateOnBoard.X);
            Display myDisplay = new Display(theBoard);
            myDisplay.DisplayCurrentBoard();
            Console.ReadKey();// if not run in debug mode, this line is needed or program will terminate after finishing
        }
    }
}
