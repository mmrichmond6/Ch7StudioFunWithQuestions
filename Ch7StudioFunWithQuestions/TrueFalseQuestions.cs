using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    internal class TrueFalseQuestions : Questions
    {
        public override string StateQuestion { get; set; }
        public override string AnswerChoiceA { get; set; }
        public override string AnswerChoiceB { get; set; }
        public override string AnswerChoiceC { get; set; }
        public override string AnswerChoiceD { get; set; }
        public override string Answer { get; set; }
        public static List<TrueFalseQuestions> fullQuizListTF = new List<TrueFalseQuestions>();


        public TrueFalseQuestions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answer) : base(stateQuestion, answerChoiceA, answerChoiceB, answerChoiceC, answerChoiceD, answer)
        {
        }
        
        public static int RunProgram(int score)
        {
            if (fullQuizListTF.Count < 1)
            {
                Console.WriteLine("There are no more question in this bank.  Choose to add a question or pick another bank.");
                score = 0;
                return score;
            }
            else
            {
                var randomchoice = new Random();
                int choice = (randomchoice.Next(1, fullQuizListTF.Count)) - 1;
                var item = fullQuizListTF[choice];

                PrintToConsole.AskQuestionFormat(item);
                Console.WriteLine("Enter your Answer Choice:  ");
                string response = Console.ReadLine();
                string input = PrintToConsole.CleanUpInputFromUser(response);

                if (input.ToUpper() != item.Answer.ToUpper())
                {
                    Console.WriteLine("Your answer is incorrect");
                    Console.WriteLine("The correct answer was: " + item.Answer);
                    score = -1;
                }
                if (input.ToUpper() == item.Answer.ToUpper())
                {
                    Console.WriteLine("Your answer is correct!");
                    score = 1;
                    fullQuizListTF.Remove(item);
                    AddQuestion.allQuestions.Remove(item);
                }
            }
        return score;
        }

        internal static void ModifyTrueFalseQuestion(string input)
        {
            throw new NotImplementedException();
        }
    }
}

