﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
        

        public TrueFalseQuestions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answer) : base(stateQuestion, answerChoiceA, answerChoiceB, answerChoiceC, answerChoiceD, answer)
        {
        }
        

        public static int RunProgram(int score)
        {
            int totalScore = score;

            TrueFalseQuestions TFQuestion1 = new("The sum of one and one is two.", "True", "False", "", "", "A");
            TrueFalseQuestions TFQuestion2 = new("The sum of one and three is two.", "True", "False", "", "", "B");
            TrueFalseQuestions TFQuestion3 = new("The difference of one and one is two.", "True", "False", "", "", "B");
            TrueFalseQuestions TFQuestion4 = new("The difference of three and one is two.", "True", "False", "", "", "A");

            List<TrueFalseQuestions> fullQuizList = new List<TrueFalseQuestions>();

            fullQuizList.Add(TFQuestion1);
            fullQuizList.Add(TFQuestion2);
            fullQuizList.Add(TFQuestion3);
            fullQuizList.Add(TFQuestion4);

            var randomchoice = new Random();
            int choice = randomchoice.Next(1, fullQuizList.Count);
            var item = fullQuizList[choice];
            
                Console.WriteLine("**********");
                Console.WriteLine("Question:  " + item.StateQuestion);
                Console.WriteLine("A:  " + item.AnswerChoiceA);
                Console.WriteLine("B:  " + item.AnswerChoiceB);
                Console.WriteLine("**********");
                Console.WriteLine("Enter your Answer Choice:  ");
                string input = Console.ReadLine();

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
            return Equals(obj as TrueFalseQuestions);
        }        
    }
}

