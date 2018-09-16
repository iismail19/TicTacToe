using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        private SetUp setUp;
        BoardGame theBoard;
        Display theDisplay;
        Players thePlayers;
        CheckWinner checkWin;
        NewGame theOption;


        // init
        public Game(SetUp s)
        {
            theBoard = s.getBoard();
            theDisplay = s.getDisplay();
            thePlayers = s.getPlayers();
            checkWin = s.getCheckWin();
            theOption = s.getOption();
        }

        // game vars
        String input;
        Boolean validInput = false;
        int position;


        // loop
        public void PlayGame()
        {

            Boolean game = true;
            CurrentStateOnBoard turn;

            //Game
            // BUG: keeps changing turn's even if player entered valid input
            while (game == true)
            {
                theDisplay.DisplayCurrentBoard();
                Console.WriteLine($"It is {thePlayers.GetCurrentPlayerName()}'s: ({thePlayers.GetTurn()}) turn");
                Console.WriteLine("Enter move");
                // Attempt to solve Input that is not an int
                EnterInput();

                // account for valid moves
                //while((position < 1) || (position > 9) || (theBoard.GetPositionState(position) != CurrentStateOnBoard.Empty))
                //{
                //    Console.WriteLine("Invalid, Re-enter move");
                //    position = Convert.ToInt32(Console.ReadLine());

                //}

                theBoard.AddtoBoard(position, thePlayers.GetTurn());
                turn = checkWin.CheckForWinner(position, theBoard);
                if (turn != CurrentStateOnBoard.Empty)
                {
                    Console.WriteLine($"Player {turn} wins!");
                    game = false;
                }
                if (checkWin.DeclareDraw(thePlayers))
                {
                    Console.WriteLine("Draw!");
                    game = false;
                }
                //theDisplay.DisplayCurrentBoard();
                // Clarity on who goes
                thePlayers.Turn();
               // Console.WriteLine($"It is player {thePlayers.Turn()}'s turn");
            }

            //Results / go back to staet
            theOption.PlayNewGame();

            //Console.ReadKey(); // prevent console from closing once program is complete
        }

        public void EnterInput()
        {
            while (validInput != true)
            {
                input = Console.ReadLine();

                validInput = Int32.TryParse(input, out position); // if true then it will be be send as position
                if ((position < 1) || (position > 9) || (theBoard.GetPositionState(position) != CurrentStateOnBoard.Empty))
                {
                    Console.WriteLine("Invalid, Re-enter move");
                    input = Console.ReadLine();

                    validInput = Int32.TryParse(input, out position);
                }

            }
            // reset validInput back to false or else it will never ask user for input again
            validInput = false;
        }


    }
}
