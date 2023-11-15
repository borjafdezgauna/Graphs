using System;


public class DirectedGraph<TKey> : UnDirectedGraph<TKey> where TKey : IComparable<TKey>
{
    public override void AddEdge(TKey sourceKey, TKey destination, double weight)
    {
        //TODO #13: Add a directed edge from source to destination
    }

    public override void RemoveNode(TKey nodeKey)
    {
        //TODO #14: Remove the node with Key=nodeKey and any edge that starts from or ends on that node
    }

    public override void RemoveEdge(TKey sourceKey, TKey destination)
    {
        //TODO #15: Remove the edge from the source node to the destination node
    }

    public override int EdgeCount()
    {
        //TODO #16: Return the number of edges in the graph
        return 0;
    }
}