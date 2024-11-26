using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class Summary
    {
        public static int numofwinsA {get; set;}
        public static int numofwinsB { get; set; }
        public static int totalstepsA { get; set; }
        public static int totalstepsB { get; set; }
        //static constructor
        static Summary()
        { numofwinsA = 0; numofwinsB = 0; totalstepsA = 0; totalstepsB = 0; }
        public int GetoOverallwinner() 
        {
            Console.WriteLine($"Game summary: \n player1 {numofwinsA} wins, {totalstepsA} total player1 steps \n  player2 {numofwinsB} wins, {totalstepsB} total player2 steps ");
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
