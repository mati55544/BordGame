
namespace BoardGame;
internal class TurnManger
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
        if (playerNumber == 1) return player1steps;
        else if (playerNumber == 2) return player2steps;
        else
            throw new ArgumentException("Invalid player number.");
    }
    public bool isPlayerWon(int playerNumber, Player player, Wincarpet carpet)
    {
        Console.WriteLine($"Player {playerNumber}'s turn. Enter a direction: 1 (Up), 2 (Down), 3 (Right), 4 (Left), 5 (Exit Game):");
        string input = Console.ReadLine()!;
        // todo koby 
        int newX = player.X, newY = player.Y;
        if (input == "1") newY--;
        else if (input == "2") newY++;
        else if (input == "3") newX++;
        else if (input == "4") newX--;
        else if (input == "5") Environment.Exit(0);

        else
        {
            Console.WriteLine("Invalid command. You missed your turn!");
            return false;
        }

        if (newX < 1 || newX > Program.WorldSize || newY < 1 || newY > Program.WorldSize)
        {
            Console.WriteLine("Out of bounds! You missed your turn!");
            return false;
        }

        IncrementSteps(playerNumber);
        player.X = newX;
        player.Y = newY;

        if (player.X >= carpet.X && player.X < carpet.X + carpet.Size && player.Y >= carpet.Y && player.Y < carpet.Y + carpet.Size)
        {
            Console.WriteLine($"Player {playerNumber} wins!");
            return true;
        }

        return false;
    }

}
