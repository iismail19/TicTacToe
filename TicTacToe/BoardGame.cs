using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class BoardGame
    {
        private String[,] board = new String[3, 3];
        
        public void SetBoard(int index, String value)
        {

            switch (index)
            {
                case 1:
                    board[0, 0] = value;
                    break;
                case 2:
                    board[0, 1] = value;
                    break;
                case 3:
                    board[0, 2] = value;
                    break;
                case 4:
                    board[1, 0] = value;
                    break;
                case 5:
                    board[1, 1] = value;
                    break;
                case 6:
                    board[1, 2] = value;
                    break;
                case 7:
                    board[2, 0] = value;
                    break;
                case 8:
                    board[2, 1] = value;
                    break;
                case 9:
                    board[2, 0] = value;
                    break;
            }

        }

        public String[,] GetArray()
        {
            return board;
        }

    }
}
