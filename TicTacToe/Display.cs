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
            for(int i = 0; i <3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    try
                    {
                        if (board[i, j].Equals(""))
                            Console.WriteLine("| ");
                        else
                            Console.Write("|" + board[i, j]);
                    }
                    catch(Exception e)
                    {
                        
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
