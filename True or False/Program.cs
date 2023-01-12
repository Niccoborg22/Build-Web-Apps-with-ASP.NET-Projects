internal class Program
{
    private static void Main(string[] args)
    {
        // INTRODUCTION
        Console.WriteLine("Welcome to 'True or False?'. Good Luck!\n");


        // SETUP
        string[] questions = {"The Big Apple is a nickname given to Washington D.C in 1971.", "Peanuts are not nuts!", "There is no snow on Minecraft.", "The Mona Liza was stolen from the Louvre in 1911.", "The Great Wall of China is visible from space."}; 
        bool[] answers = {false, true, false, true, false};
        bool[] responses = new bool[questions.Length];

        if(questions.Length != answers.Length)
        {
            Console.WriteLine("WARNING NOT ALL ANSWERS FOR THE QUESTIONS SAVED");
        }

        // QUESTIONS
        int askingIndex = 0;
        foreach (string question in questions)
        {
            Console.WriteLine("\n" + question);
            Console.WriteLine("True or False?");
            string input = Console.ReadLine();
            bool isBool;
            bool inputBool;
            isBool = Boolean.TryParse(input, out inputBool);

            while(isBool == false)
            {
            Console.WriteLine("Please respond with 'true' or 'false'.");
            input = Console.ReadLine();
            isBool = Boolean.TryParse(input, out inputBool);
            }
            responses[askingIndex] = inputBool;
            askingIndex ++;
        }
        
        // SCORE CALCULATION
        Console.WriteLine("\nSCORE");
        int scoringIndex = 0;
        int score = 0;
        foreach(bool answer in answers)
        {
            bool response = responses[scoringIndex];
            Console.WriteLine("Input: " + response + " | Answer: " + answer);
            if(response == answer)
            {
            score ++;
            }
            scoringIndex ++;
        }
        
        Console.WriteLine("Final score: " + score + " out of " + questions.Length);      
    }
}