using System;
using System.Linq;

class NumberCalculations
{
    static void Main()
    {
        Console.Write("Enter some double numbers: ");
        string inputDoubleNumbers = Console.ReadLine();
        double[] arrDoubles = inputDoubleNumbers.Split().Select(double.Parse).ToArray();


        Console.WriteLine("min =  {0}\n" +
                          "max = {1}\n" +
                          "sum = {2}\n" +
                          "average = {3}\n",Minimum(arrDoubles),Maximum(arrDoubles),Sum(arrDoubles),Average(arrDoubles));

        Console.Write("Enter some decimal numbers: ");
        string inputDecimalNumbers = Console.ReadLine();
        double[] arrDecimals = inputDecimalNumbers.Split().Select(double.Parse).ToArray();


        Console.WriteLine("min =  {0}\n" +
                          "max = {1}\n" +
                          "sum = {2}\n" +
                          "average = {3}\n", Minimum(arrDecimals), Maximum(arrDecimals), Sum(arrDecimals), Average(arrDecimals));
    }
    //Min, Max, Sum, Average Doubles
    private static double Minimum(double[] arrNumbers)
    {
        double min = arrNumbers.Min();
        return min;
    }
    private static double Maximum(double[] arrNumbers)
    {
        double max = arrNumbers.Max();
        return max;
    }
    private static double Sum(double[] arrNumbers)
    {
        double sum = arrNumbers.Sum();
        return sum;
    }
    private static double Average(double[] arrNumbers)
    {
        double average = arrNumbers.Average();
        return average;
    }
    //Min, Max. Sum, Average Decimals
    private static decimal Minimum(decimal[] arrNumbers)
    {
        decimal min = arrNumbers.Min();
        return min;
    }
    private static decimal Maximum(decimal[] arrNumbers)
    {
        decimal max = arrNumbers.Max();
        return max;
    }
    private static decimal Sum(decimal[] arrNumbers)
    {
        decimal sum = arrNumbers.Sum();
        return sum;
    }
    private static decimal Average(decimal[] arrNumbers)
    {
        decimal average = arrNumbers.Average();
        return average;
    }
}