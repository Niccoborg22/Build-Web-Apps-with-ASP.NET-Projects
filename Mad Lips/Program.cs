internal class Program
{
    private static void Main(string[] args)
    {
        /*
      This program will be able to create a short story with blanks for the player to fill and complete. The goal is to create a funny short story
      Author: Niccoló Matteo Borgato
      */
      Console.WriteLine("YOU ARE NOW ENTERING THE MATRIX\n");

      // Variables that will be entered in the story:
      // Character Name
      Console.Write("Write the main character of our Matrix story: ");
      string mainCharacter = Console.ReadLine();
      // Adjectives
      Console.Write("Write an adjective: ");
      string adjectiveOne = Console.ReadLine();
      Console.Write("Write an adjective: ");
      string adjectiveTwo = Console.ReadLine();
      Console.Write("Write an adjective: ");
      string adjectiveThree = Console.ReadLine();
      // Verb
      Console.Write("Write a verb: ");
      string verb = Console.ReadLine();
      // Nouns
      Console.Write("Write a noun: ");
      string nounOne = Console.ReadLine();
      Console.Write("Write a noun: ");
      string nounTwo = Console.ReadLine();
      // Other Inputs
      Console.Write("Write an animal: ");
      string animal = Console.ReadLine();
      Console.Write("Write a food: ");
      string food = Console.ReadLine();
      Console.Write("Write a fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("Write a superhero: ");
      string superhero = Console.ReadLine();
      Console.Write("Write a country: ");
      string country = Console.ReadLine();
      Console.Write("Write a dessert: ");
      string dessert = Console.ReadLine();
      Console.Write("Write a year: ");
      string year = Console.ReadLine();

      // ToLower of the variables
      dessert = dessert.ToLower();
      fruit = fruit.ToLower();
      food = food.ToLower();
      animal = animal.ToLower();
      nounOne = nounOne.ToLower();
      nounTwo = nounTwo.ToLower();
      verb = verb.ToLower();
      adjectiveOne = adjectiveOne.ToLower();
      adjectiveTwo = adjectiveTwo.ToLower();
      adjectiveThree = adjectiveThree.ToLower();

      // Title of the Mad Lib:
      string title = "\n\nTHE MATRIX";
      Console.WriteLine(title);

      // The template of the story:
      string story = $"\nThis morning {mainCharacter} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {mainCharacter} texted {superhero}, who flew {mainCharacter} to {country} and dropped {mainCharacter} in a puddle of frozen {dessert}. {mainCharacter} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
      Console.WriteLine("\nTHE END");
    }
}