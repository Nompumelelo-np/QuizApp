using System.Timers;

class QuizProgram
{
    static void Main()
    {
        //Create a list of questions using an array
        string[] questions =
            {
            "Which country won the 2023 Rugby World Cup? ",
            "In which 2 countries did the 2019 Cricket World Cup take place? ",
            "When did Argentina last win the FIFA World Cup "
            };
        //create Answers
        string[] answers =
        {
            "A. South Africa \nB. England  \nc. New Zealand ",
            "A. India and Pakistan \nB. England and Wales \nC. India and France",
            "A. 2021 \nB. 2018 \nC. 2022"

        };
        int[] correctanswers = {1, 2, 3};
        int playerScore = 0;

        Console.WriteLine("Welcome to my first quiz game :)");
        for (int i = 0; i < questions.Length; i++) 
        {
            Console.WriteLine("Question " + (i + 1)); //Question
            Console.WriteLine(questions[i]);
            Console.WriteLine(answers[i]);
            Console.Write("Please choose your answer ('A', 'B', 'C'): ");
            string playerAnswer = Console.ReadLine();

            //validating answers
            if (string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctanswers[i] == 0) //compare two strings
            {
                playerScore++;
            }
            else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctanswers[i] == 1)
            {
                playerScore++;
            }
            else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctanswers[i] == 2)
            {
                playerScore++;
            }

        }
         //print score to user 
         Console.WriteLine("Quiz Completed! ");
         Console.WriteLine("Your score is: " + playerScore + "/" + questions.Length);


    }
}