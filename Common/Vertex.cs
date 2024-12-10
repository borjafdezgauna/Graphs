using System;

public class Vertex<TElement, TWeight> where TElement : IComparable<TElement>
{
    public TElement Element;
    //TODO #1: Store edges starting from this vertex. Each edge has a weight and we want to be able to quickly find the edge to any other vertex
    

    public Vertex(TElement element)
    {
        //TODO #2: Initialize the vertex
        
    }

    public TElement[] ConnectedElements()
    {
        //TODO #3: Return the target vertices of the edges starting from this vertex
        
        return null;
        
    }

    public void AddEdge(TElement targetElement, TWeight weight)
    {
        //TODO #4: Add an edge from this vertex to targetElement with the given weight
        
    }

    public int EdgeCount()
    {
        //TODO #5: Return the number of edges starting from this vertex
        
        return 0;
        
    }

    public void RemoveEdge(TElement targetElement)
    {
        //TODO #6: Remove the edge connecting this vertex to the vertex containing targetElement
        
    }

    public TWeight GetEdgeWeight(TElement targetElement)
    {
        //TODO #7: Return the weight of the edge from this vertex to the vertex containing targetElement
        
        return default(TWeight);
        
    }

    public override string ToString()
    {
        //TODO #8:  Represent the edges in this vertex with the following format. In the example, there are three edges (from this -A- vertex to B, C and D):
        //          
        //          A->2.5->B
        //          A->-3.2->C
        //          A->7.32->D
        string output = null;
        
        return output;
    }
}