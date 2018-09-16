using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Display
    {
        private BoardGame board;

        public Display(BoardGame theBoard)
        {
            board = theBoard;
        }

        // Convert the current state from enum to character to be used in DisplayCurrentBoard()
        public char GetSpace(CurrentStateOnBoard state)
        {
            if (state == CurrentStateOnBoard.X)
                return 'X';
            else if (state == CurrentStateOnBoard.O)
                return 'O';
            else
                return ' ';
        }

        public char IntToChar(int num)
        {
            char[] number = num.ToString().ToCharArray();
            return number[0]; // this works for our case becuse we are using single digit numbers
        }


        public void DisplayCurrentBoard()
        {
            // Get all characters to be displayed on Board
            char[] spaceOnBoard = new char[9];  
            for(int i =1; i <= 9; i++)
            {
                char currentPos = IntToChar(i);
                //in line if (true) then a : else b -- Logic
                spaceOnBoard[i-1] =  (board.GetPositionState(i) == CurrentStateOnBoard.Empty) ? currentPos : GetSpace(board.GetPositionState(i)); 
            }

            // Display then to screen
            Console.WriteLine($"{spaceOnBoard[0]} | {spaceOnBoard[1]} | {spaceOnBoard[2]}");
            Console.WriteLine("__ __ __");
            Console.WriteLine($"{spaceOnBoard[3]} | {spaceOnBoard[4]} | {spaceOnBoard[5]}");
            Console.WriteLine("__ __ __");
            Console.WriteLine($"{spaceOnBoard[6]} | {spaceOnBoard[7]} | {spaceOnBoard[8]}");
        }

    }
}
