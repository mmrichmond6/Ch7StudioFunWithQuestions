using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

namespace Ch7StudioFunWithQuestions
{
    public class AddQuestion
    {

        public static int GatherQuestionPieces(int score)
        {
            Console.WriteLine("Which question bank should this question be added to?");
            Console.WriteLine("1) Create a True/False type question.");
            Console.WriteLine("2) Create a Multiple Choice type question.");
            Console.WriteLine("3) Create a Checkbox type question.");
            string response = Console.ReadLine();
            int input = int.Parse(response);

            if (input == 1)
            {
                Console.WriteLine("State the True/False question you would like asked: ");
                string StateQuestion = Console.ReadLine();
                string AnswerChoiceA = "True";
                string AnswerChoiceB = "False";
                string AnswerChoiceC = "";
                string AnswerChoiceD = "";

                Console.WriteLine("**********");
                Console.WriteLine("Question:  " + StateQuestion);
                Console.WriteLine("A:  " + AnswerChoiceA);
                Console.WriteLine("B:  " + AnswerChoiceB);
                Console.WriteLine("**********");
                Console.WriteLine("Which option (A or B) is the correct answer to your question?  ");
                string Answer = Console.ReadLine();

                Console.WriteLine("**********");
                TrueFalseQuestions newQuestion = new(StateQuestion, AnswerChoiceA, AnswerChoiceB, AnswerChoiceC, AnswerChoiceD, Answer);
                TrueFalseQuestions.fullQuizListTF.Add(newQuestion);
                foreach (TrueFalseQuestions item in TrueFalseQuestions.fullQuizListTF)
                {
                    Console.WriteLine("**********");
                    Console.WriteLine("Question:  " + item.StateQuestion);
                    Console.WriteLine("A:  " + item.AnswerChoiceA);
                    Console.WriteLine("B:  " + item.AnswerChoiceB);
                    Console.WriteLine("**********");
                    Console.WriteLine("Answer:  " + item.Answer);

                }
            }
            else if (input == 2)
            {
                Console.WriteLine("State the MultipleChoice question you would like asked: ");
                string StateQuestion = Console.ReadLine();
                Console.WriteLine("What answer choice would you like to place for Option A?  ");
                string AnswerChoiceA = Console.ReadLine();
                Console.WriteLine("What answer choice would you like to place for Option B?  ");
                string AnswerChoiceB = Console.ReadLine();
                Console.WriteLine("What answer choice would you like to place for Option C?  ");
                string AnswerChoiceC = Console.ReadLine();
                Console.WriteLine("What answer choice would you like to place for Option D?  ");
                string AnswerChoiceD = Console.ReadLine();

                Console.WriteLine("**********");
                Console.WriteLine("Question:  " + StateQuestion);
                Console.WriteLine("A:  " + AnswerChoiceA);
                Console.WriteLine("B:  " + AnswerChoiceB);
                Console.WriteLine("C:  " + AnswerChoiceC);
                Console.WriteLine("D:  " + AnswerChoiceD);
                Console.WriteLine("**********");

                Console.WriteLine("Which option (A, B, C, D) is the correct answer to your question?  ");
                string Answer = Console.ReadLine();

                Console.WriteLine("**********");
                MultipleChoiceQuestions newQuestion = new(StateQuestion, AnswerChoiceA, AnswerChoiceB, AnswerChoiceC, AnswerChoiceD, Answer);
                MultipleChoiceQuestions.fullQuizListMC.Add(newQuestion);
                foreach (MultipleChoiceQuestions item in MultipleChoiceQuestions.fullQuizListMC)
                {
                    Console.WriteLine("**********");
                    Console.WriteLine("Question:  " + item.StateQuestion);
                    Console.WriteLine("A:  " + item.AnswerChoiceA);
                    Console.WriteLine("B:  " + item.AnswerChoiceB);
                    Console.WriteLine("C:  " + item.AnswerChoiceC);
                    Console.WriteLine("D:  " + item.AnswerChoiceD);
                    Console.WriteLine("**********");
                    Console.WriteLine("Answer:  " + item.Answer);
                }
            }
            else if (input == 3)
            {
                Console.WriteLine("State the Checkbox question you would like asked: ");
                string StateQuestion = Console.ReadLine();
                Console.WriteLine("What answer choice would you like to place for Option A?  ");
                string AnswerChoiceA = Console.ReadLine();
                Console.WriteLine("What answer choice would you like to place for Option B?  ");
                string AnswerChoiceB = Console.ReadLine();
                Console.WriteLine("What answer choice would you like to place for Option C?  ");
                string AnswerChoiceC = Console.ReadLine();
                Console.WriteLine("What answer choice would you like to place for Option D?  ");
                string AnswerChoiceD = Console.ReadLine();

                Console.WriteLine("**********");
                Console.WriteLine("Question:  " + StateQuestion);
                Console.WriteLine("A:  " + AnswerChoiceA);
                Console.WriteLine("B:  " + AnswerChoiceB);
                Console.WriteLine("C:  " + AnswerChoiceC);
                Console.WriteLine("D:  " + AnswerChoiceD);
                Console.WriteLine("**********");

                Console.WriteLine("Which options (A, B, C, D) are the correct answer to your question?  ");
                string Answer = Console.ReadLine();

                Console.WriteLine("**********");

                CheckboxQuestions newQuestion = new(StateQuestion, AnswerChoiceA, AnswerChoiceB, AnswerChoiceC, AnswerChoiceD, Answer);
                CheckboxQuestions.fullQuizListCB.Add(newQuestion);
                foreach (CheckboxQuestions item in CheckboxQuestions.fullQuizListCB)
                {
                    Console.WriteLine("**********");
                    Console.WriteLine("Question:  " + item.StateQuestion);
                    Console.WriteLine("A:  " + item.AnswerChoiceA);
                    Console.WriteLine("B:  " + item.AnswerChoiceB);
                    Console.WriteLine("C:  " + item.AnswerChoiceC);
                    Console.WriteLine("D:  " + item.AnswerChoiceD);
                    Console.WriteLine("**********");
                    Console.WriteLine("Answer:  " + item.Answer);
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
            return score;
        }

        public static int CombineAllBanks(int score)
        {
            List<Questions> allQuestions = new List<Questions>();
            foreach (TrueFalseQuestions item in TrueFalseQuestions.fullQuizListTF)
            {
                allQuestions.Add(item);
            }
            foreach (MultipleChoiceQuestions item in MultipleChoiceQuestions.fullQuizListMC)
            {
                allQuestions.Add(item);
            }
            foreach (CheckboxQuestions item in CheckboxQuestions.fullQuizListCB)
            {
                allQuestions.Add(item);
            }

            foreach (Questions item in allQuestions)
            {
                Console.WriteLine("**********");
                Console.WriteLine("Question:  " + item.StateQuestion);
                Console.WriteLine("A:  " + item.AnswerChoiceA);
                Console.WriteLine("B:  " + item.AnswerChoiceB);
                Console.WriteLine("C:  " + item.AnswerChoiceC);
                Console.WriteLine("D:  " + item.AnswerChoiceD);
                Console.WriteLine("**********");
                Console.WriteLine("Answer:  " + item.Answer);
            }
            return score;
        }
    }
}
