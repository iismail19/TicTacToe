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

        public Boolean AddtoBoard(int index, String value)
        {

            switch (index)
            {
                case 1:
                    board[0, 0] = value;
                    return true;
                case 2:
                    board[0, 1] = value;
                    return true;
                case 3:
                    board[0, 2] = value;
                    return true;
                case 4:
                    board[1, 0] = value;
                    return true;
                case 5:
                    board[1, 1] = value;
                    return true;
                case 6:
                    board[1, 2] = value;
                    return true;
                case 7:
                    board[2, 0] = value;
                    return true;
                case 8:
                    board[2, 1] = value;
                    return true;
                case 9:
                    board[2, 0] = value;
                    return true;
                default:
                    return false; // Will retun false when an invalid index number supplied
            }

        }

        public String[,] GetArray()
        {
            return board;
        }
    }
}
