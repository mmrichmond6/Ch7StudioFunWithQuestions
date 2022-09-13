using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    public class PrintToConsole
    {
        
        public string StateQuestion { get; set; }
        public string AnswerChoiceA { get; set; }
        public string AnswerChoiceB { get; set; }
        public string AnswerChoiceC { get; set; }
        public string AnswerChoiceD { get; set; }
        public string Answer { get; set; }


        public static void AskQuestionFormat(Questions item)
        {
            Console.WriteLine("**********");
            Console.WriteLine("Question:  " + item.StateQuestion);
            Console.WriteLine("A:  " + item.AnswerChoiceA);
            Console.WriteLine("B:  " + item.AnswerChoiceB);
            Console.WriteLine("C:  " + item.AnswerChoiceC);
            Console.WriteLine("D:  " + item.AnswerChoiceD);
            Console.WriteLine("**********");
        }

        public static void VerifyQuestionFormat(Questions item)
        {
            Console.WriteLine("**********");
            Console.WriteLine("Question:  " + item.StateQuestion);
            Console.WriteLine("A:  " + item.AnswerChoiceA);
            Console.WriteLine("B:  " + item.AnswerChoiceB);
            Console.WriteLine("C:  " + item.AnswerChoiceC);
            Console.WriteLine("D:  " + item.AnswerChoiceD);
            Console.WriteLine("**********");
            Console.WriteLine("Answer:  " + item.Answer);
            Console.WriteLine("**********");
        }

        public static string CleanUpInputFromUser(string response)
        {
            if (response is null)
            {
                response = "<null>";
                return response;
            }

            string cleanup = response;
            response = Regex.Replace(cleanup, @"[^\p{L}-\s]+", "");
            cleanup = response.Replace(" ", "").ToUpper();
            response = cleanup;
            return response;
        }
    }
}
