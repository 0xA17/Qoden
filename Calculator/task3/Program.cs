using System;

namespace QodenTasks.task3;

internal class Program
{
    public static void Main()
    {
        var calculator = new PostfixCalculator();

        try
        {
            calculator.PerformCalculation(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}