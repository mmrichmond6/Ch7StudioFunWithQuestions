using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    public class ModifyActiveQuestion : Questions
    {
        

        public override string StateQuestion { get; set; }
        public override string AnswerChoiceA { get; set; }
        public override string AnswerChoiceB { get; set; }
        public override string AnswerChoiceC { get; set; }
        public override string AnswerChoiceD { get; set; }
        public override string Answer { get; set; }

        public static List<Questions> tempModList = new List<Questions>();
        public ModifyActiveQuestion(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answer) : base(stateQuestion, answerChoiceA, answerChoiceB, answerChoiceC, answerChoiceD, answer)
        {
        }

        public static void ModifyActiveQuestionPartOne()
        {

            Console.WriteLine("**********");
            Console.WriteLine("What type of question do you wish to modify:");
            Console.WriteLine("1) True/False type question.");
            Console.WriteLine("2) Multiple Choice type question.");
            Console.WriteLine("3) Checkbox type question.");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            string input = Console.ReadLine();
            int option = int.Parse(input);

            if (option == 1)
            {
                foreach (Questions question in TrueFalseQuestions.fullQuizListTF)
                {
                    tempModList.Add(question);
                }
                tempModList = ModifyItemInList(tempModList);
                for (int i = 0; i < tempModList.Count; i++)
                {
                    if (TrueFalseQuestions.fullQuizListTF[i] != tempModList[i])
                    {
                        TrueFalseQuestions.fullQuizListTF[i] = (TrueFalseQuestions)tempModList[i];
                    }
                }
                /*foreach (TrueFalseQuestions question in TrueFalseQuestions.fullQuizListTF)
                {
                    PrintToConsole.VerifyQuestionFormat(question);
                }*/

            }
            else if (option == 2)
            {
                foreach (Questions question in MultipleChoiceQuestions.fullQuizListMC)
                {
                    tempModList.Add(question);
                }
                tempModList = ModifyItemInList(tempModList);
                for (int i = 0; i < tempModList.Count; i++)
                {
                    if (MultipleChoiceQuestions.fullQuizListMC[i] != tempModList[i])
                    {
                        MultipleChoiceQuestions.fullQuizListMC[i] = (MultipleChoiceQuestions)tempModList[i];
                    }
                }
            }
            else if (option == 3)
            {
                foreach (Questions question in CheckboxQuestions.fullQuizListCB)
                {
                    tempModList.Add(question);
                }
                tempModList = ModifyItemInList(tempModList);
                for (int i = 0; i < tempModList.Count; i++)
                {
                    if (CheckboxQuestions.fullQuizListCB[i] != tempModList[i])
                    {
                        CheckboxQuestions.fullQuizListCB[i] = (CheckboxQuestions)tempModList[i];
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        private static List<Questions> ModifyItemInList(List<Questions> list)
        {
            int i = 1;
            foreach (Questions item in list)
            {
                Console.WriteLine("\nQuestion #: " + i);
                PrintToConsole.VerifyQuestionFormat(item);
                i++;
            }
            Console.WriteLine("Which question would you like to modify?");
            string input = Console.ReadLine();
            int choice = int.Parse(input) - 1;
            Console.WriteLine("You have chosen to modify the following question:  ");
            PrintToConsole.VerifyQuestionFormat(list[choice]);

            Console.WriteLine("What part of this question do you wish to change?");
            Console.WriteLine("**********");
            Console.WriteLine("Option 1) Question:  " + list[choice].StateQuestion);
            Console.WriteLine("Option 2) A:  " + list[choice].AnswerChoiceA);
            Console.WriteLine("Option 3) B:  " + list[choice].AnswerChoiceB);
            Console.WriteLine("Option 4) C:  " + list[choice].AnswerChoiceC);
            Console.WriteLine("Option 5) D:  " + list[choice].AnswerChoiceD);
            Console.WriteLine("**********");
            Console.WriteLine("Option 6) Answer:  " + list[choice].Answer);
            Console.WriteLine("**********");
            input = Console.ReadLine();
            int selection = int.Parse(input);
            if (selection == 1)
            {
                Console.WriteLine("What would you like the modified question to ask?");
                string modQuestion = Console.ReadLine();
                list[choice].StateQuestion = modQuestion;
            }
            else if (selection == 2)
            {
                Console.WriteLine("What would you like Answer Choice A to say?");
                string modAnswerA = Console.ReadLine();
                list[choice].AnswerChoiceA = modAnswerA;
            }
            else if (selection == 3)
            {
                Console.WriteLine("What would you like Answer Choice B to say?");
                string modAnswerB = Console.ReadLine();
                list[choice].AnswerChoiceB = modAnswerB;
            }
            else if (selection == 4)
            {
                Console.WriteLine("What would you like Answer Choice C to say?");
                string modAnswerC = Console.ReadLine();
                list[choice].AnswerChoiceC = modAnswerC;
            }
            else if (selection == 5)
            {
                Console.WriteLine("What would you like Answer Choice D to say?");
                string modAnswerD = Console.ReadLine();
                list[choice].AnswerChoiceD = modAnswerD;
            }
            else if (selection == 6)
            {
                Console.WriteLine("What would you like Answer to be?");
                string modAnswer = Console.ReadLine();
                modAnswer = PrintToConsole.CleanUpInputFromUser(modAnswer);

                list[choice].Answer = modAnswer;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
            Console.WriteLine("This is your modified question:  ");
            PrintToConsole.VerifyQuestionFormat(list[choice]);
            return list;
        }

    }
}
