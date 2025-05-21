using System;

public class Program
{
    public static void Main()
    {
        double divisionResult = Calculator.DivideNumbers(1, 2);
        Console.WriteLine("The result of number division is " + divisionResult);

        double averageResult = Calculator.CalculateAverage([1, 2]);
        Console.WriteLine("The result of average calculation is " + averageResult);
    }
}