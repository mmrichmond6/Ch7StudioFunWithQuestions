using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    internal class CheckboxQuestions : Questions
    {
        public override string StateQuestion { get; set; }
        public override string AnswerChoiceA { get; set; }
        public override string AnswerChoiceB { get; set; }
        public override string AnswerChoiceC { get; set; }
        public override string AnswerChoiceD { get; set; }
        public override string Answer { get; set; }
        public static List<CheckboxQuestions> fullQuizListCB = new List<CheckboxQuestions>();


        public CheckboxQuestions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answer) : base(stateQuestion, answerChoiceA, answerChoiceB, answerChoiceC, answerChoiceD, answer)
        {
        }


        public static int RunProgram(int score)
        {
            if (fullQuizListCB.Count < 1)
            {
                Console.WriteLine("There are no more question in this bank.  Choose to add a question or pick another bank.");
                return score;
            }

            var randomchoice = new Random();
            int choice = (randomchoice.Next(1, fullQuizListCB.Count)) - 1;
            var item = fullQuizListCB[choice];

            PrintToConsole.AskQuestionFormat(item);
            string response = Console.ReadLine();
            string input = PrintToConsole.CleanUpInputFromUser(response);
            
            int points = 0;

            foreach (char c in input) 
                {
                    if (item.Answer.Contains(c))
                    {
                        points++;
                    } else
                    {
                        points--;
                    }                    
                }
                
            if (points == item.Answer.Length)
            {
                Console.WriteLine("Your answer is correct!");
                score = 1;
                fullQuizListCB.Remove(item);
                AddQuestion.allQuestions.Remove(item);
            } else
                {
                Console.WriteLine("Your answer is incorrect.");
                Console.WriteLine("The correct answer was: " + item.Answer);
                score = -1;
            }          
            return score;
        }

        
    }
}
