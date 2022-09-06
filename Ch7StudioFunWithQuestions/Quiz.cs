using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    public class Quiz
    {
        public static bool MainMenu()
        {
            int score = 0;
            Console.WriteLine("**********");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Answer a True/False type question.");
            Console.WriteLine("2) Answer a Multiple Choice type question.");
            Console.WriteLine("3) Answer a Checkbox type question.");
            Console.WriteLine("4) ...");
            Console.WriteLine("5) ...");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    TrueFalseQuestions.RunProgram(score);
                    return true;
                case "2":
                    MultipleChoiceQuestions.RunProgram(score);
                    return true;
                case "3":
                    CheckboxQuestions.RunProgram(score);
                    return true;
                case "4":

                    return true;
                case "5":

                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }
    }
}

