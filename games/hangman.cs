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
        string word = words[start];


        Console.WriteLine(words[start]);

        while (wrong < 8)
        {

            Console.WriteLine("Guess a letter");

            //Maybe instead see if guess is inside of words[start]
            char guess = char.Parse(Console.ReadLine());
            char[] charArray = word.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {

            

            }

        }


        //Need code to display underscores and maybe hangman character, has to have if statements for when player guesses a correct letter

    }
}
