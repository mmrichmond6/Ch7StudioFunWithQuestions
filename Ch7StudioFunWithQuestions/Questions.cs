using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    public abstract class Questions
    {
        public abstract string StateQuestion { get; set; }
        public abstract string AnswerChoiceA { get; set; }
        public abstract string AnswerChoiceB { get; set; }
        public abstract string AnswerChoiceC { get; set; }
        public abstract string AnswerChoiceD { get; set; }
        public abstract string Answer { get; set; }

        public Questions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD, string answer)
        {
            StateQuestion = stateQuestion;
            AnswerChoiceA = answerChoiceA;
            AnswerChoiceB = answerChoiceB;
            AnswerChoiceC = answerChoiceC;
            AnswerChoiceD = answerChoiceD;
            Answer = answer;
        }


    }
}
