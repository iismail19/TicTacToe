using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class CheckWinner
    {
        // Contains the logic to check who won the game
        public CurrentStateOnBoard CheckForWinner(int position, BoardGame board)
        {
            switch (position)
            {
                case 1:
                    if (CheckTopRow(board) || CheckLeftColumn(board) || CheckLtRDiagonal(board))
                        return board.GetPositionState(1);
                    break;
                case 2:
                    if (CheckTopRow(board) || CheckMiddleColumn(board))
                        return board.GetPositionState(2);
                    break;
                case 3:
                    if (CheckTopRow(board) || CheckRightColumn(board) || CheckRtLDiagonal(board))
                        return board.GetPositionState(3);
                    break;
                case 4:
                    if (CheckMiddleRow(board) || CheckLeftColumn(board))
                        return board.GetPositionState(4);
                    break;
                case 5:
                    if (CheckMiddleRow(board) || CheckMiddleColumn(board) || CheckLtRDiagonal(board) || CheckRtLDiagonal(board))
                        return board.GetPositionState(5);
                    break;
                case 6:
                    if (CheckMiddleRow(board) || CheckRightColumn(board))
                        return board.GetPositionState(6);
                    break;
                case 7:
                    if (CheckBottomRow(board) || CheckLeftColumn(board) || CheckRtLDiagonal(board))
                        return board.GetPositionState(7);
                    break;
                case 8:
                    if (CheckBottomRow(board) || CheckMiddleColumn(board))
                        return board.GetPositionState(8);
                    break;
                case 9:
                    if (CheckBottomRow(board) || CheckRightColumn(board) || CheckLtRDiagonal(board))
                        return board.GetPositionState(9);
                    break;
                 default:
                        return CurrentStateOnBoard.Empty;
            }
            return CurrentStateOnBoard.Empty;
        }

        //Function for Draw
        public Boolean DeclareDraw(Players players)
        {
            if (players.GetTurnCount() == 9)
                return true;
            return false;
        }

        //Checks if the Top Row contains 
        public Boolean CheckTopRow(BoardGame board)
        {
            if (board.GetPositionState(1) == board.GetPositionState(2) && board.GetPositionState(1) == board.GetPositionState(3))
                return true;
            return false;
        }

        //Checks if the Middle row contains three across
        public Boolean CheckMiddleRow(BoardGame board)
        {
            if (board.GetPositionState(4) == board.GetPositionState(5) && board.GetPositionState(4) == board.GetPositionState(6))
                return true;
            return false;
        }

        //Checks if the Bottom row contains three across
        public Boolean CheckBottomRow(BoardGame board)
        {
            if (board.GetPositionState(7) == board.GetPositionState(8) && board.GetPositionState(7) == board.GetPositionState(9))
                return true;
            return false;
        }

        //Checks if the Left Column contains three down
        public Boolean CheckLeftColumn(BoardGame board)
        {
            if (board.GetPositionState(1) == board.GetPositionState(4) && board.GetPositionState(1) == board.GetPositionState(7))
                return true;
            return false;
        }

        //Checks if the Middle Column contains three down
        public Boolean CheckMiddleColumn(BoardGame board)
        {
            if (board.GetPositionState(2) == board.GetPositionState(5) && board.GetPositionState(2) == board.GetPositionState(8))
                return true;
            return false;
        }

        //Checks if the Right Column contains three down
        public Boolean CheckRightColumn(BoardGame board)
        {
            if (board.GetPositionState(3) == board.GetPositionState(6) && board.GetPositionState(3) == board.GetPositionState(9))
                return true;
            return false;
        }

        //Checks if the Left to Right Diagonal contains three across
        public Boolean CheckLtRDiagonal(BoardGame board)
        {
            if (board.GetPositionState(1) == board.GetPositionState(5) && board.GetPositionState(1) == board.GetPositionState(9))
                return true;
            return false;
        }

        //Checks if the Right to Left Diagonal contains three across
        public Boolean CheckRtLDiagonal(BoardGame board)
        {
            if (board.GetPositionState(3) == board.GetPositionState(5) && board.GetPositionState(3) == board.GetPositionState(7))
                return true;
            return false;
        }

    }
}
