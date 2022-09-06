using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        public CheckboxQuestions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answer) : base(stateQuestion, answerChoiceA, answerChoiceB, answerChoiceC, answerChoiceD, answer)
        {
        }


        public static int RunProgram(int score)
        {
            int totalScore = score;

            CheckboxQuestions CBQuestion1 = new("Choose the answer(s) that equal 2.", "2 + 0", "2 * 0", "2 - 0", "2 / 0", "AC");

            CheckboxQuestions CBQuestion2 = new("Choose the answer(s) that equal 4.", "2 + 2", "2 * 2", "2 - 2", "2 / 2", "AB");

            CheckboxQuestions CBQuestion3 = new("Choose the answer(s) that equal 6.", "2 + 4", "2 * 3", "2 - -4", "2 / 4", "ABC");

            CheckboxQuestions CBQuestion4 = new("Choose the answer(s) that equal 8.", "2 + 3", "2 * 4", "2 - 10", "8 / 1", "BD");

            List<CheckboxQuestions> fullQuizList = new List<CheckboxQuestions>();

            fullQuizList.Add(CBQuestion1);
            fullQuizList.Add(CBQuestion2);
            fullQuizList.Add(CBQuestion3);
            fullQuizList.Add(CBQuestion4);

            var randomchoice = new Random();
            int choice = randomchoice.Next(1, fullQuizList.Count);
            var item = fullQuizList[choice];

            Console.WriteLine("**********");
                Console.WriteLine("Question:  " + item.StateQuestion);
                Console.WriteLine("A:  " + item.AnswerChoiceA);
                Console.WriteLine("B:  " + item.AnswerChoiceB);
                Console.WriteLine("C:  " + item.AnswerChoiceC);
                Console.WriteLine("D:  " + item.AnswerChoiceD);
                string input = Console.ReadLine();
                input = input.Trim();
                input = input.ToUpper();
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
                    score = totalScore + 1;
                    Console.WriteLine("Your answer is correct!");

                } else
                    {
                    Console.WriteLine("Your answer is incorrect.");
                    Console.WriteLine("The correct answer was: " + item.Answer);
                }
          
            return score;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as CheckboxQuestions);
        }

    }
}
