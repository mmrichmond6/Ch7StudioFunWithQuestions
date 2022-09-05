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

        DateTime localDate = DateTime.Now;


        bool showMenu = true;
        while (showMenu)
        {
            Console.WriteLine("**********");
            Console.WriteLine("Today is:  " + localDate);
            Console.WriteLine("**********");
            Console.WriteLine("Welcome to Fun With Questions!");
            showMenu = Quiz.MainMenu();
        }
    }
}