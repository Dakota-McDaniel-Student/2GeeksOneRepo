public class Hangman
{
    int wrong = 0;

// If need to test the random in the array
// Console.Write(words[start]);

    public void Game()
    {
    
        //Chooses random word
        string[] words = { "Excellent", "Good", "Super", "Funny", "Cheeseburger", "Computer" };
        Random random = new Random();
        int start = random.Next(0, words.Length);

        Console.WriteLine(words[start]);

        while (wrong < 8)
        {

            Console.WriteLine("Guess a letter");
            char guess = char.Parse(Console.ReadLine());
            char[] charArray = start.ToCharArray();

            if (guess == )
            {

                Console.WriteLine();

            }

        }


        //Need code to display underscores and maybe hangman character, has to have if statements for when player guesses a correct letter

    }
}
