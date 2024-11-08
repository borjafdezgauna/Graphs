using System;



public class UnDirectedGraph<TElement, TWeight> where TElement : IComparable<TElement>
{
    //TODO #9:  Declare a PROTECTED member variable/attribute called Nodes. Should store nodes of type GraphNode in a way that a node can be quickly
    //          found given an element. (Look in GraphNode.cs for TODO #1)
    

    public override string ToString()
    {
        //TODO #10: Concatenate all nodes (converted to string) separated by a new line ("\n")
        string output = null;

        
        return output;
    }

    public TElement[] Elements()
    {
        //TODO #11: Return all the elements in this graph (stored in nodes) as an array
        
        return null;
        
    }

    public void AddNode(TElement element)
    {
        //TODO #12: Add a new element storing it as a node in this graph
        
    }

    public virtual void AddEdge(TElement source, TElement destination, TWeight weight)
    {
        //TODO #13: Add a new edge between source and destination with the given weight
        
    }

    public int NodeCount()
    {
        //TODO #14: Return the number of nodes in this graph
        //After doing this, you can start running tests to check that what you have done so far is correct
        
        return 0;
        
    }

    public virtual int EdgeCount()
    {
        //TODO #15: Return the number of edges. Edges are stored in each node, so nodes need to be traversed to count edges
        
        return 0;
        
    }

    public TWeight GetEdgeWeight(TElement source, TElement destination)
    {
        //TODO #16: Return the number of edges. Edges are stored in each node, so nodes need to be traversed to count edges
        
        return default;
        
    }

    public virtual void RemoveEdge(TElement source, TElement destination)
    {
        //TODO #17: Remove any edge from source to destination
        
    }

    public virtual void RemoveNode(TElement element)
    {
        //TODO #18: Remove the node with Element=element and any edge that starts from or ends on that node
        
    }

    public GraphNode<TElement, TWeight> GetNode(TElement element)
    {
        //TODO #19: Return the node that contains the given element
        
        return default;
        
    }
}