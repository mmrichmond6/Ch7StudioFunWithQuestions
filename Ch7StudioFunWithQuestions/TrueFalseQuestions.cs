using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    internal class TrueFalseQuestions : Questions
    {
        public override int Id { get; set; }
        public override string StateQuestion { get; set; }
        public override string AnswerChoiceA { get; set; }
        public override string AnswerChoiceB { get; set; }
        public override string AnswerChoiceC { get; set; }

        public override string AnswerChoiceD { get; set; }

        public bool IsTrueFalse { get; set; }

        private static readonly List<TrueFalseQuestions> tFQuestions = new List<TrueFalseQuestions>();
        public static List<TrueFalseQuestions> allTFQuestionsList = tFQuestions;



        public TrueFalseQuestions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, bool answer)
        {
            StateQuestion = stateQuestion;
            AnswerChoiceA = answerChoiceA;
            AnswerChoiceB = answerChoiceB;
            AnswerChoiceC = answerChoiceC;
            AnswerChoiceD = answerChoiceD;
            IsTrueFalse = answer;
        } 
        
        public bool IsCorrect()
        {
            return true;
        }
    }
}
