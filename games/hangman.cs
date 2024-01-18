public class Hangman
{

// If need to test the random in the array
// Console.Write(words[start]);

    public void Game()
    {

        CreateRandom();
        while (wrong < 8)
        {

            Console.WriteLine("Guess a letter");
            char guess = Console.ReadLine();
            char charArray = guess.ToCharArray();
            if (guess == char in charArray)
            {

                Console.WriteLine();

            }

        }


        //Need code to display underscores and maybe hangman character, has to have if statements for when player guesses a correct letter

    }


    public void CreateRandom()
    {

        //Chooses random word
        string[] words = { "Excellent", "Good", "Super", "Funny", "Cheeseburger", "Computer" };
        Random random = new Random();
        int start = random.Next(0, words.Length);

        Console.WriteLine(words[start]);


    }
}
