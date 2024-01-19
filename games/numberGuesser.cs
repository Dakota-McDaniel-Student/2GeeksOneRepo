using System.Net;

public class NumberGuesser
{
    public static void Game()
    {
        int numberOfGuesses = 6;
        int lowestNumber = 0;
        int highestNumber = 100;

        Random random = new Random();

        int randomNumber = random.Next(lowestNumber, highestNumber + 1);
        System.Console.WriteLine("Guess a number "+ lowestNumber + " - " + highestNumber + "\nYou get "+ numberOfGuesses + " Guesses");
        int PlayerGuess = int.Parse(Console.ReadLine());


        while (PlayerGuess != randomNumber)
        {
            if (PlayerGuess < randomNumber)
            {
                System.Console.WriteLine("Try guessing Higher.");
            }
            else
            {
                System.Console.WriteLine("Try guessing Lower");
            }
            numberOfGuesses--;
            if (numberOfGuesses > 2)
            {
                System.Console.WriteLine("You now have " + numberOfGuesses + " Guesses left.");
            }
            else
            {
                System.Console.WriteLine("You have " + numberOfGuesses + " left.");
            }
            System.Console.WriteLine("Guess another number");
            PlayerGuess = int.Parse(Console.ReadLine());
            if (numberOfGuesses < 2)
            {
                Console.WriteLine("You are out of guesses.\nThe number was " + randomNumber + "\nGame Over");
                break;
            }
        }

        if (numberOfGuesses > 1)
        {
            System.Console.WriteLine("You Guessed the number! It was " + randomNumber);
        }
    }


}