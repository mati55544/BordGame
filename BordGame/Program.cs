namespace BoardGame;

class Program
{
    
    public const int WorldSize = 30;

  


    static void Main(string[] args)
    {
          
        do
        {
            var player1 = new Player();
            player1.ReadPlayerPosition(1);


            var player2 = new Player();
            player2.ReadPlayerPosition(2);


            var carpet = new Wincarpet();
            carpet.ReadCarpetPosition();
            Console.WriteLine($"The position of the carpet is ({carpet.X}, {carpet.Y}) and the size of the carpet is {carpet.Size}");

            var board = new PrintBoard();
            

            var turn = new TurnManger();
          

            while (true)
            {
                board.PrintGameBoard(player1, player2, carpet);
                if (turn.isPlayerWon(1, player1, carpet)) 
                {
                    Summary.numofwinsA++;
                    Summary.totalstepsA += turn.GetSteps(1);
                    Summary.totalstepsB += turn.GetSteps(2);
                    break;
                }
                board.PrintGameBoard(player1, player2, carpet);

                if (turn.isPlayerWon(2, player2, carpet))
                {
                    Summary.numofwinsB++;
                    Summary.totalstepsB += turn.GetSteps(2);
                    Summary.totalstepsA += turn.GetSteps(1);
                    break;
                }


            }

            Console.WriteLine("Do you want to play again? (Y/N): ");
        }
        while (Console.ReadLine().Trim().ToUpper() == "Y");

        var result = new Summary();

        int overallwinner = result.GetoOverallwinner(); 
        if (overallwinner == 0)
        {
            Random rand = new Random();
            int randomwinner = rand.Next(1, 3);
            Console.WriteLine($"It's complitly tie the winner is player{randomwinner}.");
        }
        else
        {
            Console.WriteLine($"Congratulations to player{overallwinner}");
        }
        



        Console.ReadLine();


        {
        }
       
    }

}
            
            
        

    
    
   


