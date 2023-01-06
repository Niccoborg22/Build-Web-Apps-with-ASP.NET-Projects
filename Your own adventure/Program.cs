internal class Program
{
    private static void Main(string[] args)
    {
        /* THE MYSTERIOUS NOISE */

        // Asking for the user's name
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to our story.");

        // Start the story
        Console.WriteLine("It's a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
        Console.Write("Type YES or NO: ");
        string noiseChoice = Console.ReadLine().ToUpper();
        switch(noiseChoice)
        {
            case "NO":
            Console.WriteLine("Not much of an adventure if we don't leave our room! A croccodile enters from the window, part of the journey is the end.\nTHE END.");
            break;
            case "YES":
            Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?");
            Console.WriteLine("Type OPEN or KNOCK:");
            string doorChoice = Console.ReadLine().ToUpper();
            switch(doorChoice)
            {
                case "KNOCK":
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.WriteLine("Type your answer: ");
                string riddleAnswer = Console.ReadLine().ToUpper();
                if(riddleAnswer == "NOTHING"){
                    Console.WriteLine("The door opens and NOTHING is there. \nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                }
                else{
                    Console.WriteLine("The answer is... INCORRECT. The riddler from the Batman novels opens the door and start punching you.\nTHE END");
                }
                break;
                case "OPEN":
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.WriteLine("Enter a number (1-3): ");
                string keyChoice = Console.ReadLine().ToUpper();
                switch (keyChoice)
                {
                    case "1":
                    Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.");
                    break;
                    case "2":
                    Console.WriteLine("You choose the second key. The door doesn't open. Instead a wild tiger enters enters from the window and start eating you alive.\nTHE END.");
                    break;
                    case "3":
                    Console.WriteLine("You choose the third key. The door doesn't open. Instead a wild Tyrannosaurus Rex enters enters from the window and start eating you alive.\nTHE END.");
                    break;
                    default:
                    Console.WriteLine("Not making a choice is a choice. A polar bear suddenly enters the room and eats you alive.\nTHE END");
                    break;
                }
                break;
                default:
                Console.WriteLine("Not making a choice is a choice. A polar bear suddenly enters the room and eats you alive.\nTHE END");
                break;
            }
            break;
            default:
            Console.WriteLine("Not making a choice is a choice. A polar bear suddenly enters the room and eats you alive.\nTHE END");
            break;
        }     
    }
}