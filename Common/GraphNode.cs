using System;

public class GraphNode<TElement, TWeight> where TElement : IComparable<TElement>
{
    public TElement Element;
    //TODO #1: Store edges starting from this node. Each edge has a weight and we want to be able to quickly find the edge to any other node
    

    public GraphNode(TElement element)
    {
        //TODO #2: Initialize the node
        
    }

    public TElement[] ConnectedElements()
    {
        //TODO #3: Return the target nodes of the edges starting from this node
        
        return null;
        
    }

    public void AddEdge(TElement targetElement, TWeight weight)
    {
        //TODO #4: Add an edge from this node to targetElement with the given weight
        
    }

    public int EdgeCount()
    {
        //TODO #5: Return the number of edges starting from this node
        
        return 0;
        
    }

    public void RemoveEdge(TElement targetElement)
    {
        //TODO #6: Remove the edge connecting this node to targetNode
        
    }

    public TWeight GetEdgeWeight(TElement targetElement)
    {
        //TODO #7: Return the weight of the edge from this node to targetElement
        
        return default(TWeight);
        
    }

    public override string ToString()
    {
        //TODO #8:  Represent the edges in this node with the following format. In the example, there are three edges (from this -A- node to B, C and D):
        //          
        //          A->2.5->B
        //          A->-3.2->C
        //          A->7.32->D
        string output = null;
        
        return output;
    }
}