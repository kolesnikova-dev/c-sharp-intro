using System;

public class Calculator
{
    public static double DivideNumbers(double numerator, double denominator)
    {
        if (denominator == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return double.NaN; // Return "Not a number" to indicate an error
        }
        double result = numerator / denominator;
        return result;
    }
    
}