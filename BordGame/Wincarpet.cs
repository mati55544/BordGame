namespace BoardGame;

public class Wincarpet
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Size { get; set; }
    public void ReadCarpetPosition()
    {

        while (true)
        {
            Console.WriteLine("Please enter the left position of the winning Carpet (x y) and the size: ");
            var input = Console.ReadLine()!.Trim().Split();
            if (input.Length == 3)
            {
                X = int.Parse(input[0]);
                Y = int.Parse(input[1]);
                Size = int.Parse(input[2]);

                bool isXInBounds = X >= 1 && X + Size - 1 <= Program.WorldSize;
                bool isYInBounds = Y >= 1 && Y + Size - 1 <= Program.WorldSize;
                bool SizePositive = Size > 0 && X + Size - 1 <= Program.WorldSize && Y + Size - 1 <= Program.WorldSize;
                if (isXInBounds && isYInBounds && SizePositive)
                {
                    return;
                }
                Console.WriteLine("Invalid carpet position or size. please enter other values  ");

            }
        }
    }

}