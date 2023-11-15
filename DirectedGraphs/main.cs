using Common;
using System;
using System.Diagnostics;

class MainClass
{
    public static void Main(string[] args)
    {
        StatsUpdater statsUpdater = new StatsUpdater();
        statsUpdater.CheckGitUsername();

        if (statsUpdater.GitUsername == null)
        {
            Console.WriteLine("Error getting Git info. You need to add this project to Git (fork from my repo and then clone your fork)");
            return;
        }

        Console.WriteLine("Testing directed graphs...");
        if (!Tests.TestDirectedGraphs())
            return;

        Console.WriteLine("\nAll tests passed. Measuring speed...");
        SpeedMeasure speedMeasure = Tests.TestDistanceCalculator();

        if (!speedMeasure.Success)
        {
            Console.WriteLine("An error was detected during the speed measurement. Probably something wrong with Add/Get");
            return;
        }

        bool success = statsUpdater.AddResult(speedMeasure);
        if (success)
            Console.WriteLine("Your time was saved on the server");
        else
            Console.WriteLine("Something failed saving your time on the server");
    }
}