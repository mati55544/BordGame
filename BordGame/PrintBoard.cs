using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class PrintBoard
    {
        public void  PrintGameBoard(Point player1 , Point player2, Wincarpet carpet1)
        {
            //printing the world game 
            var world = new char[Program.WorldSize + 2,Program.WorldSize + 2];
            for (int i = 0;i < Program.WorldSize + 2; i++) 
            {
                for (int j = 0;j < Program.WorldSize + 2; j++) 
                {
                    if (i == 0 || i == Program.WorldSize + 1 || j == 0 || j == Program.WorldSize + 1)
                    {
                        world[i, j] = '#';
                    }
                    else 
                    {
                        world[i, j] = ' ';
                    }
                }
            }
            //printing wining carpet
            for (int i = 0; i < carpet1.Size; i++) 
            {
                for (int j = 0; j < carpet1.Size; j++) 
                {
                    world[carpet1.Y + i, carpet1.X + j] = '*';
                }
            }
            world[player1.Y, player1.X] = '1';
            world[player2.Y, player2.X] = '2';
            for (int i = 0; i<Program.WorldSize +2; i++) 
            {
                for (int j = 0;j < Program.WorldSize +2; j++) 
                {
                    Console.Write(world[i, j]);
                }
                Console.WriteLine();
            }

        }

    }
}
