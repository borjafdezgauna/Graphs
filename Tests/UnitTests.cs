
namespace Tests
{
    
    public class UnitTests
    {
        [Fact]
        public void UnDirectedGraphs()
        {
            Assert.True(Common.Tests.TestUnDirectedGraphs());
        }

        [Fact]
        public void DirectedGraphs()
        {
            Assert.True(Common.Tests.TestDirectedGraphs());
        }

        [Fact]
        public void DistanceCalculator()
        {
            Assert.True(Common.Tests.TestDistanceCalculator().Success);
        }

        [Fact]
        public void WriteAndReadUndirectedGraphFromFile()
        {
            UnDirectedGraph<string, double> graph = new UnDirectedGraph<string, double>();
            graph.AddNode("Jacinto");
            graph.AddNode("Nerea");
            graph.AddNode("Mertxe");
            graph.AddNode("Pakito");
            graph.AddEdge("Jacinto", "Nerea", 12.50);
            graph.AddEdge("Jacinto", "Mertxe", 2.70);
            graph.AddEdge("Jacinto", "Pakito", 3.1);
            graph.AddEdge("Nerea", "Jacinto", 4.75);
            graph.AddEdge("Pakito", "Mertxe", 10.05);
            Common.Tests.TestReaderWriter(graph, "undirected-graph-test.txt",
                (key) => key, (weight) => weight.ToString(),
                (keyString) => keyString, (weightString) => double.Parse(weightString),
                (onErrorMesssage) => Assert.Fail(onErrorMesssage),
                (onNonErrorMessage) => { });
        }
        [Fact]
        public void WriteAndReadDirectedGraphFromFile()
        {
            DirectedGraph<string, int> graph = new DirectedGraph<string, int>();
            graph.AddNode("Jacinto");
            graph.AddNode("Nerea");
            graph.AddNode("Mertxe");
            graph.AddNode("Pakito");
            graph.AddEdge("Jacinto", "Nerea", 12);
            graph.AddEdge("Jacinto", "Mertxe", 2);
            graph.AddEdge("Jacinto", "Pakito", 3);
            graph.AddEdge("Nerea", "Jacinto", 4);
            graph.AddEdge("Pakito", "Mertxe", 10);
            Common.Tests.TestReaderWriter(graph, "directed-graph-test.txt",
                (key) => key, (weight) => weight.ToString(),
                (keyString) => keyString, (weightString) => int.Parse(weightString),
                (onErrorMesssage) => Assert.Fail(onErrorMesssage),
                (onNonErrorMessage) => { });
        }

        [Fact]
        public void WriteAndReadUndirectedGraphWithSpecialCharactersFromFile()
        {
            UnDirectedGraph<string, double> graph = new UnDirectedGraph<string, double>();
            graph.AddNode("Jacinto->Filomeno");
            graph.AddNode("Nerea\nAlonsotegi");
            graph.AddNode("Mertxe");
            graph.AddNode("Pakito");
            graph.AddEdge("Jacinto->Filomeno", "Nerea\nAlonsotegi", 12.50);
            graph.AddEdge("Jacinto->Filomeno", "Mertxe", 2.70);
            graph.AddEdge("Jacinto->Filomeno", "Pakito", 3.1);
            graph.AddEdge("Nerea\nAlonsotegi", "Jacinto->Filomeno", 4.75);
            graph.AddEdge("Pakito", "Mertxe", 10.05);
            Common.Tests.TestReaderWriter(graph, "undirected-graph-special-test.txt",
                (key) => key, (weight) => weight.ToString(),
                (keyString) => keyString, (weightString) => double.Parse(weightString),
                (onErrorMesssage) => Assert.Fail(onErrorMesssage),
                (onNonErrorMessage) => { });
        }
        [Fact]
        public void WriteAndReadDirectedGraphWithSpecialCharactersFromFile()
        {
            DirectedGraph<string, int> graph = new DirectedGraph<string, int>();
            graph.AddNode("Jacinto->Filomeno");
            graph.AddNode("Nerea\nAlonsotegi");
            graph.AddNode("Mertxe");
            graph.AddNode("Pakito");
            graph.AddEdge("Jacinto->Filomeno", "Nerea\nAlonsotegi", 12);
            graph.AddEdge("Jacinto->Filomeno", "Mertxe", 2);
            graph.AddEdge("Jacinto->Filomeno", "Pakito", 3);
            graph.AddEdge("Nerea\nAlonsotegi", "Jacinto->Filomeno", 4);
            graph.AddEdge("Pakito", "Mertxe", 10);
            Common.Tests.TestReaderWriter(graph, "directed-graph-special-test.txt",
                (key) => key, (weight) => weight.ToString(),
                (keyString) => keyString, (weightString) => int.Parse(weightString),
                (onErrorMesssage) => Assert.Fail(onErrorMesssage),
                (onNonErrorMessage) => { });
        }
    }
}