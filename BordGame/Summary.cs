using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    internal class Summary
    {
        public static int numofwinsA = 0;
        public static int numofwinsB = 0;
        public static int totalstepsA = 0;
        public static int totalstepsB = 0;
        public int GetoOverallwinner() //(int numofwinsA, int numofwinsB, int totalstepsA, int totalstepsB)
        {
            Console.WriteLine($"Game summary: \n player1 {numofwinsA} wins, {totalstepsA} total player1 steps \n  player2 {numofwinsB} wins, {totalstepsB} total player1 steps ");
            if (numofwinsA > numofwinsB)
            {
                Console.WriteLine("player1 is the overall winner!");
                return 1;
            }
            else if (numofwinsA < numofwinsB)
            {
                Console.WriteLine("player2 is the overall winner!");
                return 2;
            }
            else
            {
                if (totalstepsA > totalstepsB)
                { Console.WriteLine("It's a tie of wins, but player1 did more steps player1 is the winner!!"); return 1; }
                else if (totalstepsA < totalstepsB)
                { Console.WriteLine("It's a tie of wins, but player2 did more steps player2 is the winner!!"); return 2; }
                else
                {

                    return 0;
                }
            }

        }


    }
}
