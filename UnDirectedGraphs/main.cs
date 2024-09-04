using System;
using System.Diagnostics;
using Common;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing undirected graphs...");
        if (!Tests.TestUnDirectedGraphs())
            return;

    }
}