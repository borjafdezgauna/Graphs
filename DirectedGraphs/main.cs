using Common;
using System;
using System.Diagnostics;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing directed graphs...");
        if (!Tests.TestDirectedGraphs())
            return;

        Console.WriteLine("\nAll tests passed. Testing distance calculator...");
        SpeedMeasure speedMeasure = Tests.TestDistanceCalculator();

        if (!speedMeasure.Success)
        {
            Console.WriteLine("An error was detected testing the distance calculator");
            return;
        }

        Console.WriteLine($"All tests passed. Time: {speedMeasure.Time}s");
    }
}