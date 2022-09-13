using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    public class Quiz
    {
        public static int score;
        public static bool MainMenu()
        {
            Console.WriteLine("**********");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Answer a True/False type question.");
            Console.WriteLine("2) Answer a Multiple Choice type question.");
            Console.WriteLine("3) Answer a Checkbox type question.");
            Console.WriteLine("4) Add a NEW question to the question bank.");
            Console.WriteLine("5) Print all questions in the bank.");
            Console.WriteLine("6) Let computer choose random question type.");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    score = TrueFalseQuestions.RunProgram(score);
                    return true;
                case "2":
                    score = MultipleChoiceQuestions.RunProgram(score);
                    return true;
                case "3":
                    score = CheckboxQuestions.RunProgram(score);
                    return true;
                case "4":
                    score = AddQuestion.GatherQuestionPieces(score);
                    return true;
                case "5":
                    score = AddQuestion.CombineAllBanks(score);
                    return true;
                case "6":
                    var randomchoice = new Random();
                    int choice = randomchoice.Next(1, 3);
                    if (choice == 1)
                    {
                        score = TrueFalseQuestions.RunProgram(score);
                    }
                    if (choice == 2)
                    {
                        score = MultipleChoiceQuestions.RunProgram(score);
                    }
                    if (choice == 3)
                    {
                        score = CheckboxQuestions.RunProgram(score);
                    }
                    return true;
                case "7":
                    Console.WriteLine("Your final score is:  " + score);
                    return false;
                default:
                    return true;
            }
        }
    }
}

