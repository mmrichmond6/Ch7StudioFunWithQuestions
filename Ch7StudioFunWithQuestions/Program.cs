﻿using Ch7StudioFunWithQuestions;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        //The Main method within Program will do four things:
        //* Create several questions
        //* Present questions to the user (random or user select type?)
        //* Accept user response
        //* Respond to answer given (correct or incorrect) and Score

        MultipleChoiceQuestions MCQuestion1 = new("The sum of one and one is:", "0", "2", "4", "6", "B");
        MultipleChoiceQuestions MCQuestion2 = new("The sum of one and three is:", "0", "2", "4", "6", "C");
        MultipleChoiceQuestions MCQuestion3 = new("The difference of one and one is:", "0", "2", "4", "6", "A");
        MultipleChoiceQuestions MCQuestion4 = new("The difference of three and one is:", "0", "2", "4", "6", "B");

        MultipleChoiceQuestions.fullQuizListMC.Add(MCQuestion1);
        MultipleChoiceQuestions.fullQuizListMC.Add(MCQuestion2);
        MultipleChoiceQuestions.fullQuizListMC.Add(MCQuestion3);
        MultipleChoiceQuestions.fullQuizListMC.Add(MCQuestion4);

        TrueFalseQuestions TFQuestion1 = new("The sum of one and one is two.", "True", "False", "", "", "A");
        TrueFalseQuestions TFQuestion2 = new("The sum of one and three is two.", "True", "False", "", "", "B");
        TrueFalseQuestions TFQuestion3 = new("The difference of one and one is two.", "True", "False", "", "", "B");
        TrueFalseQuestions TFQuestion4 = new("The difference of three and one is two.", "True", "False", "", "", "A");

        TrueFalseQuestions.fullQuizListTF.Add(TFQuestion1);
        TrueFalseQuestions.fullQuizListTF.Add(TFQuestion2);
        TrueFalseQuestions.fullQuizListTF.Add(TFQuestion3);
        TrueFalseQuestions.fullQuizListTF.Add(TFQuestion4);

        CheckboxQuestions CBQuestion1 = new("Choose the answer(s) that equal 2.", "2 + 0", "2 * 0", "2 - 0", "2 / 0", "AC");
        CheckboxQuestions CBQuestion2 = new("Choose the answer(s) that equal 4.", "2 + 2", "2 * 2", "2 - 2", "2 / 2", "AB");
        CheckboxQuestions CBQuestion3 = new("Choose the answer(s) that equal 6.", "2 + 4", "2 * 3", "2 - -4", "2 / 4", "ABC");
        CheckboxQuestions CBQuestion4 = new("Choose the answer(s) that equal 8.", "2 + 3", "2 * 4", "2 - 10", "8 / 1", "BD");

        CheckboxQuestions.fullQuizListCB.Add(CBQuestion1);
        CheckboxQuestions.fullQuizListCB.Add(CBQuestion2);
        CheckboxQuestions.fullQuizListCB.Add(CBQuestion3);
        CheckboxQuestions.fullQuizListCB.Add(CBQuestion4);

        bool showMenu = true;
        while (showMenu)
        {
            Console.WriteLine("**********");
            Console.WriteLine("Welcome to Fun With Questions!");
            Console.WriteLine("Your score so far is:  " + Quiz.score);
            showMenu = Quiz.MainMenu();
        }
    }
}