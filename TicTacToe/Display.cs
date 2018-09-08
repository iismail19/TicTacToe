using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Display
    {
        private String[,] board;

        public Display(BoardGame theBoard)
        {
            board = theBoard.GetArray();
        }

        public void DisplayCurrentBoard()
        {

        }
    }
}
