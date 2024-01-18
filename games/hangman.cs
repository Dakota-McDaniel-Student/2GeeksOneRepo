public class Hangman
{

// If need to test the random in the array
// Console.Write(words[start]);

    public void Game()
    {

        CreateRandom();
        //Need code to display underscores and maybe hangman character, has to have if statements for when player guesses a correct letter

    }


    public void CreateRandom()
    {

        //Chooses random word
        string[] words = { "Excellent", "Good", "Super", "Funny", "Cheeseburger", "Computer" };
        Random random = new Random();
        int start = random.Next(0, words.Length);

        Console.Write(words[start]);


    }
}
