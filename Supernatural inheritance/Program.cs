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

        // Test the Mage class
        Mage m1 = new Mage("Nicco");
        Storm s3 = m1.CastRainStorm();
        Console.WriteLine(s3.Announce());

        // Test the Archmage class
        Archmage a1 = new Archmage("Nicco");
        Storm s4 = a1.CastRainStorm();
        Storm s5 = a1.CastLightningStorm();
        Console.WriteLine(s4.Announce());
        Console.WriteLine(s5.Announce());
    }
}