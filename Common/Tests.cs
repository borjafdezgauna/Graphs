using System;
using System.Diagnostics;

namespace Common
{
    
    public class Tests
    {
        public static bool TestUnDirectedGraphs()
        {
            UnDirectedGraph<string, double> graph = new UnDirectedGraph<string, double>();

            graph.AddNode("Maider");
            graph.AddNode("Itxaso");
            graph.AddNode("Galder");
            graph.AddNode("Alaitz");

            graph.AddEdge("Maider", "Itxaso", 5.2);
            graph.AddEdge("Itxaso", "Maider", 3.12);
            graph.AddEdge("Itxaso", "Galder", 83.23);
            graph.AddEdge("Itxaso", "Alaitz", 12.0);
            graph.AddEdge("Alaitz", "Galder", 102.3);
            graph.AddEdge("Maider", "Galder", 63.23);
            graph.AddEdge("Maider", "Alaitz", 87.12);

            Console.WriteLine($"Test graph:\n{graph.ToString()}");

            Console.Write("Testing AddNode(), AddEdge(), NodeCount() and EdgeCount()...");

            int numVertices = graph.NodeCount();
            if (numVertices != 4)
            {
                Console.WriteLine($"Error. NodeCount() returned {numVertices} instead of 4");
                return false;
            }

            int numEdges = graph.EdgeCount();
            if (numEdges != 6)
            {
                Console.WriteLine($"Error. EdgeCount() returned {numEdges} instead of 6");
                return false;
            }

            graph.AddEdge("Galder", "Alaitz", 16.2);
            numEdges = graph.EdgeCount();
            if (numEdges != 6)
            {
                Console.WriteLine($"Error. AddEdge() with existing edge failed. Added a new edge instead of updating the value");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing GetEdgeWeight() with existing edges...");
            if (graph.GetEdgeWeight("Maider", "Itxaso") != 3.12)
            {
                Console.WriteLine($"Error. GetEdgeWeight(\"Maider\",\"Itxaso\") returned {graph.GetEdgeWeight("Maider", "Itxaso")} instead of 3.12");
                return false;
            }

            if (graph.GetEdgeWeight("Alaitz", "Galder") != 16.2)
            {
                Console.WriteLine($"Error. GetEdgeWeight(\"Alaitz\",\"Galder\") returned {graph.GetEdgeWeight("Alaitz", "Galder")} instead of 16.2");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing GetEdgeWeight() with non-existing edge...");
            if (graph.GetEdgeWeight("Maider", "Pedro") != 0)
            {
                Console.WriteLine($"Error. GetEdgeWeight(\"Maider\",\"Pedro\") returned {graph.GetEdgeWeight("Maider", "Pedro")} instead of 0");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing RemoveEdge() with existing edge...");
            graph.RemoveEdge("Alaitz", "Galder");
            numEdges = graph.EdgeCount();
            if (numEdges != 5)
            {
                Console.WriteLine($"Error. EdgeCount() returned {numEdges} instead of 5");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing RemoveEdge() with non-existing edge...");
            graph.RemoveEdge("Alaitz", "Galder");
            numEdges = graph.EdgeCount();
            if (numEdges != 5)
            {
                Console.WriteLine($"Error. EdgeCount() returned {numEdges} instead of 5");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing RemoveNode() with existing edge...");
            graph.RemoveNode("Galder");
            numVertices = graph.NodeCount();
            if (numVertices != 3)
            {
                Console.WriteLine($"Error. NodeCount() returned {numVertices} instead of 3");
                return false;
            }
            numEdges = graph.EdgeCount();
            if (numEdges != 3)
            {
                Console.WriteLine($"Error. RemoveNode() failed to remove edges connected to the vertex removed");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing RemoveNode() with non-existing edge...");
            numEdges = graph.EdgeCount();
            if (numEdges != 3)
            {
                Console.WriteLine($"Error. EdgeCount() returned {numEdges} instead of 3");
                return false;
            }

            Console.WriteLine("Ok.");

            return true;
        }

        public static bool TestDirectedGraphs()
        {
            DirectedGraph<string, double> graph = new DirectedGraph<string, double>();

            graph.AddNode("Maider");
            graph.AddNode("Itxaso");
            graph.AddNode("Galder");
            graph.AddNode("Alaitz");

            graph.AddEdge("Maider", "Itxaso", 5.2);
            graph.AddEdge("Itxaso", "Maider", 3.12);
            graph.AddEdge("Itxaso", "Galder", 83.23);
            graph.AddEdge("Itxaso", "Alaitz", 12.0);
            graph.AddEdge("Alaitz", "Galder", 102.3);
            graph.AddEdge("Maider", "Galder", 63.23);
            graph.AddEdge("Maider", "Alaitz", 87.12);

            Console.WriteLine($"Test graph:\n{graph.ToString()}");

            Console.Write("Testing AddNode(), AddEdge(), NodeCount() and EdgeCount()...");

            int numVertices = graph.NodeCount();
            if (numVertices != 4)
            {
                Console.WriteLine($"Error. NodeCount() returned {numVertices} instead of 4");
                return false;
            }

            int numEdges = graph.EdgeCount();
            if (numEdges != 7)
            {
                Console.WriteLine($"Error. EdgeCount() returned {numEdges} instead of 7");
                return false;
            }

            graph.AddEdge("Alaitz", "Galder", 16.2);
            numEdges = graph.EdgeCount();
            if (numEdges != 7)
            {
                Console.WriteLine($"Error. AddEdge() with existing edge failed. Added a new edge instead of updating the value");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing GetEdgeWeight() with existing edges...");
            if (graph.GetEdgeWeight("Maider", "Itxaso") != 5.2)
            {
                Console.WriteLine($"Error. GetEdgeWeight(\"Maider\",\"Itxaso\") returned {graph.GetEdgeWeight("Maider", "Itxaso")} instead of 5.2");
                return false;
            }

            if (graph.GetEdgeWeight("Alaitz", "Galder") != 16.2)
            {
                Console.WriteLine($"Error. GetEdgeWeight(\"Alaitz\",\"Galder\") returned {graph.GetEdgeWeight("Alaitz", "Galder")} instead of 16.2");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing GetEdgeWeight() with non-existing edge...");
            if (graph.GetEdgeWeight("Maider", "Pedro") != 0)
            {
                Console.WriteLine($"Error. GetEdgeWeight(\"Maider\",\"Pedro\") returned {graph.GetEdgeWeight("Maider", "Pedro")} instead of 0");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing RemoveEdge() with existing edge...");

            graph.RemoveEdge("Alaitz", "Galder");
            numEdges = graph.EdgeCount();
            if (numEdges != 6)
            {
                Console.WriteLine($"Error. After removing an edge (\"Alaitz\",\"Galder\") EdgeCount() returned {numEdges} instead of 6");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing RemoveEdge() with non-existing edge...");
            graph.RemoveEdge("Alaitz", "Galder");
            numEdges = graph.EdgeCount();
            if (numEdges != 6)
            {
                Console.WriteLine($"Error. EdgeCount() returned {numEdges} instead of 6");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing RemoveNode() with existing edge...");
            graph.RemoveNode("Galder");
            numVertices = graph.NodeCount();
            if (numVertices != 3)
            {
                Console.WriteLine($"Error. NodeCount() returned {numVertices} instead of 3");
                return false;
            }
            numEdges = graph.EdgeCount();
            if (numEdges != 4)
            {
                Console.WriteLine($"Error. RemoveNode() failed to remove edges from/to removed vertex");
                return false;
            }
            Console.WriteLine("Ok.");

            Console.Write("Testing RemoveNode() with non-existing edge...");
            numEdges = graph.EdgeCount();
            if (numEdges != 4)
            {
                Console.WriteLine($"Error. EdgeCount() returned {numEdges} instead of 4");
                return false;
            }

            Console.WriteLine("Ok.");

            return true;
        }

        public static SpeedMeasure TestDistanceCalculator()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int numSamples = 1000;
            for (int i = 0; i < numSamples; i++)
            {
                DistanceCalculator calculator = new DistanceCalculator();

                calculator.AddCity("Donostia-SS");
                calculator.AddCity("Vitoria-Gasteiz");
                calculator.AddCity("Bilbo");
                calculator.AddCity("Altsasu");
                calculator.AddCity("Beasain");
                calculator.AddCity("Santander");
                calculator.AddCity("Tolosa");
                calculator.AddCity("Andoain");
                calculator.AddCity("Agurain");
                calculator.AddCity("Beasain");
                calculator.AddCity("Lekeitio");
                calculator.AddCity("Durango");
                calculator.AddCity("Deba");
                calculator.AddCity("Iruñea");
                calculator.AddCity("Lizarra");
                calculator.AddCity("Irun");

                calculator.AddDistance("Agurain", "Vitoria-Gasteiz", 30.28);
                calculator.AddDistance("Altsasu", "Agurain", 20.5);
                calculator.AddDistance("Beasain", "Altsasu", 22.3);
                calculator.AddDistance("Beasain", "Tolosa", 16.8);
                calculator.AddDistance("Andoain", "Tolosa", 12.2);
                calculator.AddDistance("Donostia-SS", "Andoain", 15.8);
                calculator.AddDistance("Donostia-SS", "Deba", 41.4);
                calculator.AddDistance("Donostia-SS", "Irun", 27.8);
                calculator.AddDistance("Iruñea", "Irun", 78.4);
                calculator.AddDistance("Durango", "Deba", 37.4);
                calculator.AddDistance("Deba", "Vitoria-Gasteiz", 67.3);
                calculator.AddDistance("Lekeitio", "Durango", 37.2);
                calculator.AddDistance("Bilbo", "Durango", 34.2);
                calculator.AddDistance("Bilbo", "Vitoria-Gasteiz", 65.2);
                calculator.AddDistance("Bilbo", "Santander", 99.9);
                calculator.AddDistance("Altsasu", "Iruñea", 50.4);
                calculator.AddDistance("Andoain", "Iruñea", 67.8);
                calculator.AddDistance("Lizarra", "Iruñea", 44.4);
                calculator.AddDistance("Lizarra", "Vitoria-Gasteiz", 72.4);

                //Distances from Vitoria-Gasteiz
                IDictionary<string, double> distances = calculator.CalculateDistances("Vitoria-Gasteiz");

                if (Math.Abs(distances.Get("Donostia-SS") - 108.7) > 0.1)
                {
                    Console.WriteLine($"Calculated distance between \"Vitoria-Gasteiz\" and \"Donostia-SS\" is {distances.Get("Donostia-SS")} instead of 108.7");
                    return new SpeedMeasure() { Success = false };
                }
                if (Math.Abs(distances.Get("Lekeitio") - 136.6) > 0.1)
                {
                    Console.WriteLine($"Calculated distance between \"Vitoria-Gasteiz\" and \"Lekeitio\" is {distances.Get("Lekeitio")} instead of 136.6");
                    return new SpeedMeasure() { Success = false };
                }
                if (Math.Abs(distances.Get("Santander") - 165.1) > 0.1)
                {
                    Console.WriteLine($"Calculated distance between \"Vitoria-Gasteiz\" and \"Santander\" is {distances.Get("Lekeitio")} instead of 165.1");
                    return new SpeedMeasure() { Success = false };
                }

                //Distances from Donostia-SS
                distances = calculator.CalculateDistances("Donostia-SS");

                if (Math.Abs(distances.Get("Vitoria-Gasteiz") - 108.7) > 0.1)
                {
                    Console.WriteLine($"Calculated distance between \"Vitoria-Gasteiz\" and \"Donostia-SS\" is {distances.Get("Donostia-SS")} instead of 108.7");
                    return new SpeedMeasure() { Success = false };
                }
                if (Math.Abs(distances.Get("Lekeitio") - 116) > 0.1)
                {
                    Console.WriteLine($"Calculated distance between \"Vitoria-Gasteiz\" and \"Lekeitio\" is {distances.Get("Lekeitio")} instead of 116");
                    return new SpeedMeasure() { Success = false };
                }
                if (Math.Abs(distances.Get("Santander") - 212.9) > 0.1)
                {
                    Console.WriteLine($"Calculated distance between \"Donostia-SS\" and \"Santander\" is {distances.Get("Santander")} instead of 212.9");
                    return new SpeedMeasure() { Success = false };
                }
            }

            return new SpeedMeasure() { Success = true, Time = stopwatch.Elapsed.TotalSeconds };
        }

        private static bool CompareGraphs<TKey, TWeight>(UnDirectedGraph<TKey, TWeight> graph1,
            UnDirectedGraph<TKey, TWeight> graph2, Action<string> onError) where TKey: IComparable<TKey>
        {
            if (graph1 == null || graph2 == null)
            {
                onError($"Something failed reading/writing a graph to disk. The graph read from file was null");
                return false;
            }
            if (graph1.NodeCount() != graph2.NodeCount())
            {
                onError($"The original graph and the one read from file have a different number of elements ({graph1.NodeCount()} and {graph2.NodeCount()})");
                return false;
            }

            foreach (TKey key in graph1.Elements())
            {
                TKey[] nodesInGraph1 = graph1.Elements();
                TKey[] nodesInGraph2 = graph2.Elements();

                foreach(TKey nodeKey in nodesInGraph1)
                {
                    GraphNode<TKey, TWeight> node1 = graph1.GetNode(nodeKey);
                    GraphNode<TKey, TWeight> node2 = graph2.GetNode(nodeKey);
                    if (node1 == null || node2 == null)
                    {
                        onError($"The nodes read from file are not equal to those in the original graph");
                        return false;
                    }

                    TKey[] nodesConnectedToNode1 = node1.ConnectedElements();
                    TKey[] nodesConnectedToNode2 = node2.ConnectedElements();
                    if (nodesConnectedToNode1.Length != nodesConnectedToNode2.Length)
                    {
                        onError($"A node in the graph read from file didn't have the same number of edges as the original");
                        return false;
                    }

                }
            }
            return true;
        }


        public static bool TestReaderWriter<TKey, TWeight>(UnDirectedGraph<TKey, TWeight> dictionary,
            string filename,
            Func<TKey, string> keyToString, Func<TWeight, string> valueToString,
            Func<string, TKey> stringToKey, Func<string, TWeight> weightToValue,
            Action<string> onError, Action<string> onNonErrorMessage) where TKey: IComparable<TKey>
        {
            GraphReaderWriter readerWriter = new GraphReaderWriter();
            bool success = readerWriter.Write(dictionary, filename, (key) => keyToString(key), (value) => valueToString(value));
            if (!success)
                onError("Something went wrong writing the graph to a file");

            UnDirectedGraph<TKey, TWeight> readFromFile = (UnDirectedGraph<TKey, TWeight>)Activator.CreateInstance(dictionary.GetType());

            success = readerWriter.Read(readFromFile, filename, (keyString) => stringToKey(keyString), (valueString) => weightToValue(valueString));
            if (!success)
                onError("Something went wrong reading the graph from the file");

            success = CompareGraphs(dictionary, readFromFile, onError);

            if (success)
                onNonErrorMessage("Ok");
            return success;
        }
    }
}