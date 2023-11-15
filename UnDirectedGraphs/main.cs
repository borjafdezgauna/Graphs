using System;
using System.Diagnostics;
using Common;
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

        Console.WriteLine("Testing undirected graphs...");
        if (!Tests.TestUnDirectedGraphs())
            return;

        statsUpdater.AddResult(null);
    }
}