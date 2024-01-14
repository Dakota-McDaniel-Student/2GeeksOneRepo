public class Hangman
{
    //Chooses random word
    static string[] words = { "Excellent", "Good", "Super", "Funny", "Cheeseburger", "Computer" };
    Random random = new Random();
    int start = random.Next(0, words.Length);

// If need to test the random in the array
// Console.Write(words[start]);

    public void Game()
    {

        //Need code to display underscores and maybe hangman character, has to have if statements for when player guesses a correct letter

    }
}