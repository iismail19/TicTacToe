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

        private int ply1Score;
        private int ply2Score;
        private int numberOfGames;

        // initialize the players and the score
        public Players(String n1, String n2, int nGames)
        {
            player1 = n1;
            player2 = n2;
            ply1Score = 0;
            ply2Score = 0;
            numberOfGames = nGames;
        }

        // When we add an AI.. second player name is not needed
        public Players(String n1, int nGames)
        {
            player1 = n1;
            player2 = "Computer";
            ply1Score = 0;
            ply2Score = 0;
            numberOfGames = nGames;
        }

        // getters

        // setters

        // keep track of turn fucntion, to change change the CurrentStateOnBoard from X to O and vice-versa



    }
}
