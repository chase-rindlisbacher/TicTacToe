using System;
// Chase Rindlisbacher, Izzy Sampson, James Lear, Eddy Rodriguez
// Mission 3 Assignment, Tic-Tac-Toe game
namespace Mission3Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            Support su = new Support();
            // Welcome players to the game
            Console.WriteLine("Welcome! I hope you're ready to play some TicTacToe!");
            // create board array, it will be printed before each move, position placeholders will be replaced
            // as players place their X's and O's
            string[] board = new string[] {"1","2","3","4","5","6","7","8","9"};
            // print board method
            su.PrintCurrentBoard(board);

            // Set boolean for if the game is over
            Boolean Gameover = false;
            // ask players for choice and update the array
            while (Gameover == false)
            {
                // Set boolean for whether you should be asking a player to place their guess until they enter a valid position
                Boolean keepgoing = true;
                while (keepgoing == true)
                {
                    Console.WriteLine("Player 1, where would you like to place your next X");
                    // grab their input then convert to an int
                    string playerGuess1 = Console.ReadLine();
                    int Guess1 = Convert.ToInt32(playerGuess1);
                    // begin if statement to check if the place they're guessing has already been taken then update array
                    if (Guess1 > 0 && Guess1 < 10 && board[(Guess1 - 1)] != "O" && board[(Guess1 - 1)] != "X")
                    {
                        board[(Guess1 - 1)] = "X";
                        keepgoing = false;
                    }
                    // force them to pick a spot that hasn't already been selected
                    else
                    {
                        Console.WriteLine("Try again, but this time in a valid position");
                    }
                }
                // printboard method
                su.PrintCurrentBoard(board);
                // checkwin method
                Gameover = su.Winner(board);
                // reset boolean to true for while loop
                if (Gameover == true) 
                {
                    keepgoing = false;
                }
                else
                {
                    keepgoing = true;
                }
                // same thing as you did with player 1
                while (keepgoing == true)
                {

                    Console.WriteLine("Player 2, where would you like to place your next O");
                    string playerGuess2 = Console.ReadLine();
                    int Guess2 = Convert.ToInt32(playerGuess2);
                    if (Guess2 > 0 && Guess2 < 10 && board[(Guess2 - 1)] != "O" && board[(Guess2 - 1)] != "X")
                    {
                        board[(Guess2 - 1)] = "O";
                        keepgoing = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again, but this time in a valid position");
                    }
                }
                // printboard method
                su.PrintCurrentBoard(board);
                // checkwin method
                Gameover = su.Winner(board);
            }
        }
    }
}
