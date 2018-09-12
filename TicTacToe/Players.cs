using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Players
    {
        // Class should hold two players max
        // second player could be an AI(Later figured out)

        private String player1;
        private String player2;
        private CurrentStateOnBoard turn = CurrentStateOnBoard.X;

        private int ply1Score;
        private int ply2Score;
        //private int numberOfGames;
        private int turnCount;

        // initialize the players and the score
        public Players(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
            ply1Score = 0;
            ply2Score = 0;
            turnCount = 0;
        }

        // When we add an AI.. second player name is not needed
        //public Players(String n1, int nGames)
        //{
        //    player1 = n1;
        //    player2 = "Computer";
        //    ply1Score = 0;
        //    ply2Score = 0;
        //    numberOfGames = nGames;
        //    turnCount = 0;
        //}

        // getters
        public String GetPlayer1Name ()
        {
            return player1;
        }

        public String GetPlayer2Name()
        {
            return player2;
        }

        public CurrentStateOnBoard GetTurn()
        {
            return turn;
        }

        public int GetPly1Score()
        {
            return ply1Score;
        }

        public int GetPly2Score()
        {
            return ply2Score;
        }

        //public int GetNumberOfGames()
        //{
        //    return numberOfGames;
        //}

        public int GetTurnCount()
        {
            return turnCount;
        }

        // setters
        public void SetPlayer1Name(String name)
        {
            player1 = name;
        }

        public void SetPlayer2Name(String name)
        {
            player2 = name;
        }

        // keep track of turn fucntion, to change change the CurrentStateOnBoard from X to O and vice-versa
        public CurrentStateOnBoard Turn()
        {
            if (turn == CurrentStateOnBoard.X)
                turn = CurrentStateOnBoard.O;
            else if(turn == CurrentStateOnBoard.O)
                turn = CurrentStateOnBoard.X;
            turnCount++;
            return turn;
        }


    }
}
