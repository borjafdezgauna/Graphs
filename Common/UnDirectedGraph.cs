using System;



public class UnDirectedGraph<TKey> where TKey : IComparable<TKey>
{
    //TODO #4:  Declare a member variable/attribute called Nodes. Should store nodes of type GraphNode in a way that a node can be quickly
    //          found given its key. (Look in GraphNode.cs for TODO #1)

    public string AsString()
    {
        //TODO #5: Concatenate all nodes converted to string
        return null;
    }

    public void AddNode(TKey nodeKey)
    {
        //TODO #6: Add a new node with this key
    }

    public int NodeCount()
    {
        //TODO #7: Return the number of nodes
        return 0;
    }

    public virtual int EdgeCount()
    {
        //TODO #8: Return the number of edges. Edges are stored in each node, so nodes need to be traversed to count edges
        return 0;
    }

    public virtual void RemoveNode(TKey nodeKey)
    {
        //TODO #9: Remove the node with Key=nodeKey and any edge that starts from or ends on that node
    }

    public double GetEdgeWeight(TKey source, TKey destination)
    {
        //TODO #10: Find the edge between source and destination, and return the weight of the edge that connects both. O if there is no edge
        return 0;
    }

    public virtual void AddEdge(TKey source, TKey destination, double weight)
    {
        //TODO #11: Add a new edge between source and destination with the given weight
    }

    public virtual void RemoveEdge(TKey source, TKey destination)
    {
        //TODO #12: Remove any edge from source to destination
    }
}