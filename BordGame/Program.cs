namespace BoardGame;

public class Program
{
    
    public const int WorldSize = 30;

  


    static void Main(string[] args)
    {
          
        do
        {
            var point1 = new Point();
            point1.ReadPointPosition("player 1");


           var point2 = new Point();
            point2.ReadPointPosition("player 2");
            

            var carpet = new Wincarpet();
            carpet.ReadCarpetPosition();
            Console.WriteLine($"The position of the carpet is ({carpet.X}, {carpet.Y}) and the size of the carpet is {carpet.Size}");

            var board = new PrintBoard();
            

            var playerturn = new Player();
          

            while (true)
            {
                board.PrintGameBoard(point1, point2, carpet);
                if (playerturn.isPlayerWon(1, point1, carpet)) 
                {
                    Summary.numofwinsA++;
                    Summary.totalstepsA += playerturn.GetSteps(1);
                    Summary.totalstepsB += playerturn.GetSteps(2);
                    break;
                }
                board.PrintGameBoard(point1, point2, carpet);

                if (playerturn.isPlayerWon(2, point2, carpet))
                {
                    Summary.numofwinsB++;
                    Summary.totalstepsB += playerturn.GetSteps(2);
                    Summary.totalstepsA += playerturn.GetSteps(1);
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
            
            
        

    
    
   


