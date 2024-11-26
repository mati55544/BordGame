namespace BoardGame;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public void ReadPointPosition(string title )
    {
        while (true)
        {
            try
            {
                Console.WriteLine($"Please Enter the position of , {title} ,x and y ,please use spacebar between x and y:");
                string[] input = Console.ReadLine().Trim().Split();
                if (input.Length != 2)
                {
                    Console.WriteLine("Invalid input: please enter exactly two numbers separated by a spacebar .");
                    continue;

                }
                X = int.Parse(input[0]);
                Y = int.Parse(input[1]);


                if (X < 1 || X > Program.WorldSize || Y < 1 || Y > Program.WorldSize)
                {
                    Console.WriteLine($"Invalid position: values must be between 1 and {Program.WorldSize}");
                    continue;
                }
                Console.WriteLine($" {title} position: ({X}, {Y}) ");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: both values must be integers ");
            }
           


        }
    }
}


