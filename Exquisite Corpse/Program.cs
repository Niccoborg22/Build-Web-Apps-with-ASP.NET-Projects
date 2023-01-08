internal class Program
{
    private static void Main(string[] args)
    {
        BuildACreature("Ghost", "monster", "lion");
        Console.WriteLine("----------------------------------");
        RandomMode();
    }

    // Method to build a creature automatically
    static void BuildACreature(string head, string body, string feet)
    {
      // Switch statement to choose the right part of the body called
      switch(head.ToLower())
      {
        case "ghost":
          GhostHead();
          break;
        case "bug":
          BugHead();
          break;
        case "monster":
          MonsterHead();
          break;
        default:
          MonsterHead();
          break;
      }
      switch(body.ToLower())
      {
        case "ghost":
          GhostBody();
          break;
        case "bug":
          BugBody();
          break;
        case "monster":
          MonsterBody();
          break;
        default:
          MonsterBody();
          break;
      }
      switch(feet.ToLower())
      {
        case "ghost":
          GhostFeet();
          break;
        case "bug":
          BugFeet();
          break;
        case "monster":
          MonsterFeet();
          break;
        default:
          MonsterFeet();
          break;
      }
    }

    // Random generator of ASCII creature
    static void RandomMode()
    {
      Random randomNumber = new Random();
      int head = randomNumber.Next(1,4);
      int body = randomNumber.Next(1,4);
      int feet = randomNumber.Next(1,4);
      SwitchCase(head, body, feet);
    }

    // Method to switch from the numbers generated from the random generator to the names we need to call the BuildACreature method
    static void SwitchCase(int head, int body, int feet)
    {
      switch(head)
      {
        case 1:
          GhostHead();
          break;
        case 2:
          BugHead();
          break;
        case 3:
          MonsterHead();
          break;
        default:
          MonsterHead();
          break;
      }
      switch(body)
      {
        case 1:
          GhostBody();
          break;
        case 2:
          BugBody();
          break;
        case 3:
          MonsterBody();
          break;
        default:
          MonsterBody();
          break;
      }
      switch(feet)
      {
        case 1:
          GhostFeet();
          break;
        case 2:
          BugFeet();
          break;
        case 3:
          MonsterFeet();
          break;
        default:
          MonsterFeet();
          break;
      }
    }

    // Methods with the different parts of a creature 
    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }    
    
}