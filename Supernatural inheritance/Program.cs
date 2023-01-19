internal class Program
{
    private static void Main(string[] args)
    {
        // Test the Storm class
        Storm s1 = new Storm("wind", false, "Nicco");
        Console.WriteLine(s1.Announce());

        // Test the Pupil class
        Pupil p1 = new Pupil("Nicco");
        Storm s2 = p1.CastWindStorm();
        Console.WriteLine(s2.Announce());
    }
}