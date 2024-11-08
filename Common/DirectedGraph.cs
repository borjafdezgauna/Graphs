using System;


public class DirectedGraph<TItem, TWeight> : UnDirectedGraph<TItem, TWeight> where TItem : IComparable<TItem>
{
    public override void AddEdge(TItem sourceKey, TItem destination, TWeight weight)
    {
        //TODO #24: Add a directed edge from source to destination
        
    }

    public override void RemoveNode(TItem nodeKey)
    {
        //TODO #25: Remove the node with Key=nodeKey and any edge that starts from or ends on that node
        
    }

    public override void RemoveEdge(TItem sourceKey, TItem destination)
    {
        //TODO #26: Remove the edge from the source node to the destination node
        
    }

    public override int EdgeCount()
    {
        //TODO #27: Return the number of edges in the graph
        
        return 0;
        
    }
}