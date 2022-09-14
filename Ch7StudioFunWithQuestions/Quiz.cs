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
        public static int missed;
        private static int value;
        private static int passFail;
        public static bool MainMenu()
        {
            Console.WriteLine("**********");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Answer a True/False type question.");
            Console.WriteLine("2) Answer a Multiple Choice type question.");
            Console.WriteLine("3) Answer a Checkbox type question.");
            Console.WriteLine("4) Let computer choose random question type.");
            Console.WriteLine("5) Add a NEW question to any question bank.");
            Console.WriteLine("6) Modify an ACTIVE question in any question bank.");
            Console.WriteLine("7) See all active questions.");
            Console.WriteLine("8) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    passFail = TrueFalseQuestions.RunProgram(value);
                    AdjustScore(passFail);
                    return true;
                case "2":
                    passFail = MultipleChoiceQuestions.RunProgram(value);
                    AdjustScore(passFail);
                    return true;
                case "3":
                    passFail = CheckboxQuestions.RunProgram(value);
                    AdjustScore(passFail);
                    return true;
                case "4":
                    var randomchoice = new Random();
                    int choice = randomchoice.Next(1, 3);
                    if (choice == 1)
                    {
                        passFail = TrueFalseQuestions.RunProgram(value);
                        AdjustScore(passFail);
                    }
                    if (choice == 2)
                    {
                        passFail = MultipleChoiceQuestions.RunProgram(value);
                        AdjustScore(passFail);
                    }
                    if (choice == 3)
                    {
                        passFail = CheckboxQuestions.RunProgram(value);
                        AdjustScore(passFail);
                    }
                    return true;
                case "5":
                    passFail = AddQuestion.GatherQuestionPieces(value);
                    return true;
                case "6":
                    ModifyActiveQuestion.ModifyActiveQuestionPartOne();
                    return true;
                case "7":
                    passFail = AddQuestion.CombineAllBanks(value);
                    return true;
                case "8":
                    Console.WriteLine("Your final correct is:  " + score);
                    Console.WriteLine("Your final missed is:  " + missed);
                    return false;
                default:
                    Console.WriteLine("Invalid choice.");
                    return true;
            }
        }

        private static void AdjustScore(int passFail)
        {
            if (passFail == 1)
            {
                Quiz.score++;
            }
            else if (passFail == -1)
            {
                Quiz.missed++;
            }
            else if (passFail == 0)
            {
                Console.WriteLine("No change is scores.");
            }
            else
            {
                Console.WriteLine("Do not need a catch all 'else'?");
            }
        }
    }
}