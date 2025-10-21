using Common;
using System;
using System.Diagnostics;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing directed graphs...");
        if (!Tests.TestDirectedGraphs(Console.WriteLine, Console.WriteLine))
            return;

        Stopwatch stopwatch = Stopwatch.StartNew();
        Console.WriteLine("\nAll tests passed. Testing distance calculator...");
        bool success = Tests.TestDistanceCalculator(Console.WriteLine, Console.WriteLine);

        if (!success)
        {
            Console.WriteLine("An error was detected testing the distance calculator");
            return;
        }

        Console.WriteLine($"Time: {stopwatch.Elapsed.TotalSeconds}s");

        Console.Write("Testing GraphReaderWriter with a directed graph...");
        DirectedGraph<string, double> graph = new DirectedGraph<string, double>();

        graph.AddVertex("Maider");
        graph.AddVertex("Itxaso");
        graph.AddVertex("Galder");
        graph.AddVertex("Alaitz");

        graph.AddEdge("Maider", "Itxaso", 5.2);
        graph.AddEdge("Itxaso", "Maider", 3.12);
        graph.AddEdge("Itxaso", "Galder", 83.23);
        graph.AddEdge("Itxaso", "Alaitz", 12.0);
        graph.AddEdge("Alaitz", "Galder", 102.3);
        graph.AddEdge("Maider", "Galder", 63.23);
        graph.AddEdge("Maider", "Alaitz", 87.12);

        success = Common.Tests.TestReaderWriter(graph, "directed-graph-test.txt", (word) => word, (number) => number.ToString(),
            (wordString) => wordString, (numberString) => double.Parse(numberString),
            (onErrorMessage) => { Console.WriteLine(onErrorMessage); },
            (onNonErrorMessage) => { Console.WriteLine(onNonErrorMessage); });
        if (!success)
            return;

        Console.WriteLine("\nAll tests passed");
    }
}