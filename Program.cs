public class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("What game would you like to play");
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "hangman")
        {
            Console.Clear();
            Hangman hangmanGame = new Hangman();
            Console.WriteLine("You are now playing Hangman.");
            hangmanGame.Game();

        }
    }
    
    
}