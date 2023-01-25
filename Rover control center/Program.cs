internal class Program
{
    private static void Main(string[] args)
    {
        MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
        MoonRover apollo = new MoonRover("Apollo 15", 1971);
        MarsRover sojourner = new MarsRover("Sojourner", 1997);
        Satellite sputnik = new Satellite("Sputnik", 1957); 

        // List of all the rovers in Space 
        Rover[] roverList = {lunokhod, apollo, sojourner};

        DirectAll(roverList);

        Console.WriteLine("\n---------------------------------\n");

        // List of all the space Probes
        Object[] spaceProbes = {lunokhod, apollo, sojourner, sputnik};

        // For loop to check everything is working in the right way 
        foreach(Object spaceProbe in spaceProbes)
        {
            Console.WriteLine(spaceProbe.GetType());
        }

        Console.WriteLine("\n---------------------------------\n");
        
        // Now that we have created the IDirectable interface we can create a list of type IDirectable[]
        IDirectable[] spaceProbesIDi = {lunokhod, apollo, sojourner, sputnik};
        
        DirectAllProbes(spaceProbesIDi);

    }

    // Method to command all the rovers in the Space Station
    public static void DirectAll(Rover[] roverList)
    {
        foreach(Rover rover in roverList)
        {
            Console.WriteLine(rover.GetInfo());
            Console.WriteLine(rover.Explore());
            Console.WriteLine(rover.Collect());
        }
    }

    // Method to command all the probes in the Space Station
    public static void DirectAllProbes(IDirectable[] probesList)
    {
        foreach(IDirectable probe in probesList)
        {
            Console.WriteLine(probe.GetInfo());
            Console.WriteLine(probe.Explore());
            Console.WriteLine(probe.Collect());
        }
    }
}