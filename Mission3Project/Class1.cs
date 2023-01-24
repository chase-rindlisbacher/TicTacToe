using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Project
{
    class Support
    {
        string[] normal = { "1", "2", "3", "4", "5", "6", "7", "8","9" };
        public void PrintCurrentBoard(string[] positions)
        {
            Console.WriteLine("    |     |    ");
            Console.WriteLine(" " + positions[0] + "  |  " + positions[1] + "  |  " + positions[2] + " ");
            Console.WriteLine("____|_____|____");
            Console.WriteLine("    |     |    ");
            Console.WriteLine(" " + positions[3] + "  |  " + positions[4] + "  |  " + positions[5] + " ");
            Console.WriteLine("____|_____|____");
            Console.WriteLine("    |     |    ");
            Console.WriteLine(" " + positions[6] + "  |  " + positions[7] + "  |  " + positions[8] + " ");
            Console.WriteLine("    |     |    ");
        }
        public bool Winner(string[] positions)
        {
            int catGame = 0;
            for (int i = 0; i < 9; i++)
            {
                if (positions[i] == normal[i])
                {
                    catGame++;
                }
            }
            //top horizontal
            if (positions[0] == positions[1] && positions[1] == positions[2])
            {
                Console.WriteLine(positions[0] + " wins!");
                return true;
            }
            //diagonal sloping down to the right
            else if (positions[0] == positions[4] && positions[4] == positions[8])
            {
                Console.WriteLine(positions[0] + " wins!");
                return true;
            }
            // left vertical
            else if (positions[0] == positions[3] && positions[3] == positions[6])
            {
                Console.WriteLine(positions[0] + " wins!");
                return true;
            }
            // middle horizontal
            else if (positions[3] == positions[4] && positions[4] == positions[5])
            {
                Console.WriteLine(positions[3] + " wins!");
                return true;
            }
            // bottom horizontal
            else if (positions[6] == positions[7] && positions[7] == positions[8])
            {
                Console.WriteLine(positions[6] + " wins!");
                return true;
            }
            // middle vertical
            else if (positions[1] == positions[4] && positions[4] == positions[7])
            {
                Console.WriteLine(positions[1] + " wins!");
                return true;
            }
            // right vertical
            else if (positions[2] == positions[5] && positions[5] == positions[8])
            {
                Console.WriteLine(positions[2] + " wins!");
                return true;
            }
            // diagonal sloping down to the left
            else if (positions[2] == positions[4] && positions[4] == positions[6])
            {
                Console.WriteLine(positions[2] + " wins!");
                return true;
            }
            else if (catGame == 0)
            {
                Console.WriteLine("Cat game!");
                return true;
            }
            // return no winner
            else
            {
                Console.WriteLine("No winner");
                return false;
            }
        }
    }
}

