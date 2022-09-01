using Ch7StudioFunWithQuestions;

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
        TrueFalseQuestions TFQuestion1 = new("The sum of one and one is two.", "True", "False", "", "", true);
        TrueFalseQuestions.allTFQuestionsList.Add(TFQuestion1);
        TrueFalseQuestions TFQuestion2 = new("The sum of one and three is two.", "True", "False", "", "", false);
        TrueFalseQuestions.allTFQuestionsList.Add(TFQuestion2);
        TrueFalseQuestions TFQuestion3 = new("The difference of one and one is two.", "True", "False", "", "", false);
        TrueFalseQuestions.allTFQuestionsList.Add(TFQuestion3);
        TrueFalseQuestions TFQuestion4 = new("The difference of three and one is two.", "True", "False", "", "", true);
        TrueFalseQuestions.allTFQuestionsList.Add(TFQuestion4);

        bool showMenu = true;
        while (showMenu)
        {
            Console.WriteLine("**********");
            Console.WriteLine("Today is:  " + localDate);
            Console.WriteLine("**********");
            Console.WriteLine("Welcome to Fun With Questions!");
            showMenu = MainMenu();
        }
    }
    private static bool MainMenu()
    {
        Console.WriteLine("**********");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Answer a T/F type question.");
        Console.WriteLine("2) ...");
        Console.WriteLine("3) ...");
        Console.WriteLine("4) ...");
        Console.WriteLine("5) View full current Quiz");
        Console.WriteLine("6) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                //MenuItem.AddNewItem();
                return true;
            case "2":
                //Menu.SearchAndRemoveItem();
                return true;
            case "3":
                //Menu.SearchAndModifyItem();
                return true;
            case "4":
                //Menu.SearchAndPrintItem();
                return true;
            case "5":
                //Menu.OrganizeListByCategory();
                //Menu.PrintAllMenu();
                return true;
            case "6":
                return false;
            default:
                return true;
        }
    }
}