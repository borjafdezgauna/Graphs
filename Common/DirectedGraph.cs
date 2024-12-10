using System;


public class DirectedGraph<TElement, TWeight> : UnDirectedGraph<TElement, TWeight> where TElement : IComparable<TElement>
{
    public override void AddEdge(TElement sourceKey, TElement destination, TWeight weight)
    {
        //TODO #24: Add a directed edge from source to destination
        
    }

    public override void RemoveVertex(TElement element)
    {
        //TODO #25: Remove the vertex that contains this element and any edge that starts from or ends on that vertex
        
    }

    public override void RemoveEdge(TElement sourceKey, TElement destination)
    {
        //TODO #26: Remove the edge from the source vertex to the destination vertex
        
    }

    public override int EdgeCount()
    {
        //TODO #27: Return the number of edges in the graph
        
        return 0;
        
    }
}