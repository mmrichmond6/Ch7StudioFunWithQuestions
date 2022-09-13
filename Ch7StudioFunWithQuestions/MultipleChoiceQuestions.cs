using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    internal class MultipleChoiceQuestions : Questions
    {
        public override string StateQuestion { get; set; }
        public override string AnswerChoiceA { get; set; }
        public override string AnswerChoiceB { get; set; }
        public override string AnswerChoiceC { get; set; }
        public override string AnswerChoiceD { get; set; }
        public override string Answer { get; set; }
        public static List<MultipleChoiceQuestions> fullQuizListMC = new List<MultipleChoiceQuestions>();

        public MultipleChoiceQuestions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answer) : base(stateQuestion, answerChoiceA, answerChoiceB, answerChoiceC, answerChoiceD, answer)
        {
        }
        public static int RunProgram(int score)
        {
            int totalScore = score;

            var randomchoice = new Random();
            int choice = randomchoice.Next(1, fullQuizListMC.Count);
            var item = fullQuizListMC[choice];

            PrintToConsole.AskQuestionFormat(item);
            Console.WriteLine("Enter your Answer Choice:  ");
            string response = Console.ReadLine();
            string input = PrintToConsole.CleanUpInputFromUser(response);

            if (input.ToUpper() != item.Answer.ToUpper())
                {
                    Console.WriteLine("Your answer is incorrect");
                    Console.WriteLine("The correct answer was: " + item.Answer);
                }
                if (input.ToUpper() == item.Answer.ToUpper())
                {
                    Console.WriteLine("Your answer is correct!");
                    score = totalScore + 1;
                }               
            return score;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MultipleChoiceQuestions);
        }
    }
}
