internal class Program
{
    private static void Main(string[] args)
    {
        Profile sam = new Profile("Sam Drakkila", 12, "Milan", "Italy");
        string[] hobby = {"Driving cars", "Play football"};
        sam.SetHobbies(hobby);
        Console.WriteLine(sam.ViewProfile());
    }
}