public static class Hangman
{

// If need to test the random in the array
// Console.Write(words[start]);

    public static void Game()
    {

        Random();
        Console.Write(words[start]);
        //Need code to display underscores and maybe hangman character, has to have if statements for when player guesses a correct letter

    }
}

public static string Random()
{

    //Chooses random word
    static string[] words = { "Excellent", "Good", "Super", "Funny", "Cheeseburger", "Computer" };
    Random random = new Random();
    int start = random.Next(0, words.Length);

}