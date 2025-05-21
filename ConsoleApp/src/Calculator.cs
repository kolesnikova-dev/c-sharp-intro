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

    public static double CalculateAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }

}