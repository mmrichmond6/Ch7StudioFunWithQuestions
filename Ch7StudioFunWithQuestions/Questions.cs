using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7StudioFunWithQuestions
{
    public abstract class Questions
    {
        public abstract int Id { get; set; }
        private static int nextId = 1;

        public abstract string StateQuestion { get; set; }
        public abstract string AnswerChoiceA { get; set; }
        public abstract string AnswerChoiceB { get; set; }
        public abstract string AnswerChoiceC { get; set; }
        public abstract string AnswerChoiceD { get; set; }


        public Questions()
        {
            Id = nextId;
            nextId++;
        }

        public Questions(string stateQuestion, string answerChoiceA, string answerChoiceB, string answerChoiceC, string answerChoiceD)
        {
            StateQuestion = stateQuestion;
            AnswerChoiceA = answerChoiceA;
            AnswerChoiceB = answerChoiceB;
            AnswerChoiceC = answerChoiceC;
            AnswerChoiceD = answerChoiceD;
        }


    }
}
