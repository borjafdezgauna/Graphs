using System;

public class GraphNode<TKey> where TKey : IComparable<TKey>
{
    public TKey NodeKey;
    
    //TODO #1: Store edges starting from this node. Each edge has a weight and we want to be able to quickly find the edge to any other node

    public GraphNode(TKey nodeKey)
    {
        //TODO #2: Initialize the node
    }

    public override string ToString()
    {
        //TODO #3:  Represent the edges in this node with the following format. In the example, there are three edges (from this -A- node to B, C and D):
        //          
        //          A -- B --> 2.5
        //          A -- C --> -3.2
        //          A -- D --> 7.32

        return null;
    }
}