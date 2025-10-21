using System;
using System.Diagnostics;
using Common;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing undirected graphs...");
        if (!Tests.TestUnDirectedGraphs(Console.WriteLine, Console.WriteLine))
            return;

        Console.Write("Testing GraphReaderWriter with an undirected graph...");
        UnDirectedGraph<string, double> graph = new UnDirectedGraph<string, double>();

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

        bool success = Common.Tests.TestReaderWriter(graph, "undirected-graph-test.txt", (word) => word, (number) => number.ToString(),
            (wordString) => wordString, (numberString) => double.Parse(numberString),
            (errorMessage) => { Console.WriteLine(errorMessage); },
            (onNonErrorMessage) => { Console.WriteLine(onNonErrorMessage); });
        if (!success)
            return;

        Console.WriteLine("\nAll tests passed");
    }
}