using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        public MultipleChoiceQuestions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answer) : base(stateQuestion, answerChoiceA, answerChoiceB, answerChoiceC, answerChoiceD, answer)
        {
        }
        public static int RunProgram(int score)
        {
            MultipleChoiceQuestions MCQuestion1 = new("The sum of one and one is:", "0", "2", "4", "6", "B");

            MultipleChoiceQuestions MCQuestion2 = new("The sum of one and three is:", "0", "2", "4", "6", "C");

            MultipleChoiceQuestions MCQuestion3 = new("The difference of one and one is:", "0", "2", "4", "6", "A");

            MultipleChoiceQuestions MCQuestion4 = new("The difference of three and one is:", "0", "2", "4", "6", "B");

            List<MultipleChoiceQuestions> fullQuizList = new List<MultipleChoiceQuestions>();

            fullQuizList.Add(MCQuestion1);
            fullQuizList.Add(MCQuestion2);
            fullQuizList.Add(MCQuestion3);
            fullQuizList.Add(MCQuestion4);

            foreach (var item in fullQuizList)
            {
                Console.WriteLine("**********");
                Console.WriteLine("Question:  " + item.StateQuestion);
                Console.WriteLine("A:  " + item.AnswerChoiceA);
                Console.WriteLine("B:  " + item.AnswerChoiceB);
                Console.WriteLine("C:  " + item.AnswerChoiceC);
                Console.WriteLine("D:  " + item.AnswerChoiceD);
                Console.WriteLine("**********");
                Console.WriteLine("Enter your Answer Choice:  ");
                string input = Console.ReadLine();

                if (input.ToUpper() != item.Answer.ToUpper())
                {
                    Console.WriteLine("Your answer is incorrect");
                    Console.WriteLine("The correct answer was: " + item.Answer);
                    Console.WriteLine("Your quiz score is:  " + score);
                }
                if (input.ToUpper() == item.Answer.ToUpper())
                {
                    Console.WriteLine("Your answer is correct!");
                    score = score + 1;
                    Console.WriteLine("Your quiz score is:  " + score);
                }
                Console.WriteLine("Would you like another MC type Question?  Type Y for yes or N for no.");
                string output = Console.ReadLine();
                if (output.ToUpper() == "N")
                {
                    return score;
                }
            }
            return score;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MultipleChoiceQuestions);
        }


    }
}
