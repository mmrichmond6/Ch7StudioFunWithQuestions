using Ch7StudioFunWithQuestions;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        //The Main method within Program will do four things:
        //* Create several questions
        //* Present questions to the user (random or user select type?)
        //* Accept user response
        //* Respond to answer given (correct or incorrect) and Score

        
        bool showMenu = true;
        while (showMenu)
        {
            Console.WriteLine("**********");
            Console.WriteLine("Welcome to Fun With Questions!");
            Console.WriteLine("Your score so far is:  " + Quiz.score);
            showMenu = Quiz.MainMenu();
        }
    }
}