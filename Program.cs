
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerRoll;
        int computerRoll;

        do
        {
            playerRoll = random.Next(1, 7);
            computerRoll = random.Next(1, 7);

            Console.WriteLine($"Your roll: {playerRoll}");
            Console.WriteLine($"Computer roll: {computerRoll}");

            if (playerRoll > computerRoll)
            {
                Console.WriteLine("You win!");
            }
            else if (computerRoll > playerRoll)
            {
                Console.WriteLine("Computer wins!");
            }
            else
            {
                Console.WriteLine("It's a tie! Rolling again...");
            }

            Console.WriteLine();

        } while (playerRoll == computerRoll);
    }
}

