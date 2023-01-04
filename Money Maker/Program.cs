internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Money Maker!\nThis algorithm will return the minim number of coins you need to have the money you are need");

        // Ask the user how much money to convert
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("How much money you need?");
        string valueStr = Console.ReadLine();
        // Convert the number if not an integer
        double valueDbl = Convert.ToDouble(valueStr);
        int value = (int)Math.Round(valueDbl);

        // Definition of the coins
        int goldCoin = 10;
        int silverCoin = 5;

        // Time to start the calculations
        Console.WriteLine("\n" + value + " cents is equal to...");
        int numGold = value/goldCoin;
        int valueRest = value%goldCoin;
        int numSilver = valueRest/silverCoin;
        int numBronze = valueRest%silverCoin;

        // Print the output
        Console.WriteLine("Gold coins: " + numGold);
        Console.WriteLine("Silver coins: " + numSilver);
        Console.WriteLine("Gold coins: " + numBronze);
    }
}