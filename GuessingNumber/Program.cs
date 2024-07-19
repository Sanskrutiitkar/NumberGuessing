using System;

class NumberGuessingGame
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain;

        do
        {
            int randomNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game");
            Console.WriteLine("I have generated a random number between 1 and 100. can you guess it?");

        
            while (guess != randomNumber)
            {
                Console.Write("Enter your guess: ");
               
                string input = Console.ReadLine();

           
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                attempts++; 

                if (guess < randomNumber)
                {
                    Console.WriteLine("Sorry, too low.");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Sorry, too high.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number {randomNumber} in {attempts} attempts.");
                }
            }

            
            Console.Write("Do you want to play again? (y/n): ");
            string playAgainInput = Console.ReadLine();
            playAgain = playAgainInput.Equals("y", StringComparison.OrdinalIgnoreCase);
        } while (playAgain);

        Console.WriteLine("Thank you for playing! Goodbye!");
    }
}