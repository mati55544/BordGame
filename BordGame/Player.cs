
namespace BoardGame;
internal class Player
{
    private int player1steps = 0;
    private int player2steps = 0;

    public  void  IncrementSteps(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1steps++;
        }
        else if (playerNumber == 2)
        {
            player2steps++;
        }
    }
    public int GetSteps(int playerNumber)
    {
        if (playerNumber == 1) 
        {
            return player1steps;
        }
           
        else if (playerNumber == 2) 
        {
            return player2steps;
        }
        else
            throw new ArgumentException("Invalid player number.");
    }
    public bool isPlayerWon(int playerNumber, Point point, Wincarpet carpet)
    {
        Console.WriteLine($"Player {playerNumber}'s turn. Enter a direction: 1 (Up), 2 (Down), 3 (Right), 4 (Left), 5 (Exit Game):");
        int input = Convert.ToInt32(Console.ReadLine());

        
        int newX = point.X, newY = point.Y;
        Summary exitmiddle = new Summary();
        switch (input) 
        {
            case 1:
                newY--;
                break;
            case 2:
                newY++;
                break;
            case 3:
                newX++;
                break;
            case 4:
                newX--;
                break;
            case 5:
                exitmiddle.GetoOverallwinner(); Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid command. You missed your turn!");
                return false;

        }
        //if (input == "1") newY--;
        //else if (input == "2") newY++;
        //else if (input == "3") newX++;
        //else if (input == "4") newX--;
        //else if (input == "5") { exitmiddle.GetoOverallwinner(); Environment.Exit(0); }
        ////Environment.Exit(0)



        //else
        //{
        //    Console.WriteLine("Invalid command. You missed your turn!");
        //    return false;
        //}

        if (newX < 1 || newX > Program.WorldSize || newY < 1 || newY > Program.WorldSize)
        {
            Console.WriteLine("Out of bounds! You missed your turn!");
            return false;
        }

        IncrementSteps(playerNumber);
        point.X = newX;
        point.Y = newY;

        if (point.X >= carpet.X && point.X < carpet.X + carpet.Size && point.Y >= carpet.Y && point.Y < carpet.Y + carpet.Size)
        {
            Console.WriteLine($"Player {playerNumber} wins!");
            return true;
        }

        return false;
    }

}
