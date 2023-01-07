internal class Program
{
    private static void Main(string[] args)
    {
        // Calculation of the Teotihuacan religious center in Mexico
      // Main areas to be calculated
      double mainRectangle = AreaRectangle(1500,2500);
      double halfCircle = (AreaCircle(187.5)/2);
      double triangle = AreaTriangle(750,500);
      double TeotihuacanArea = mainRectangle + halfCircle + triangle;

      // Each meter squared will have a cost of 180 Mexican pesos
      double totalCost = TeotihuacanArea*180; 
      totalCost = Math.Round(totalCost, 2);
      Console.WriteLine($"The total cost per meter squared of the Teotihuacan is: {totalCost} Mexican Pesos");
      
    }

    // Method to calculate the area of the rectangle
    static double AreaRectangle(double lenght, double width)
    {
      return (lenght*width);
    }

    // Method to calculate the area of a circle
    static double AreaCircle(double radius)
    {
      return (Math.PI*Math.Pow(radius,2));
    }

    // Method to calculate the area of a triangle
    static double AreaTriangle(double bottom, double height)
    {
      return (0.5*bottom*height);
    }
}