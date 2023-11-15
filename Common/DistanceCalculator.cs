using System;


public class DistanceCalculator
{

    //TODO #16: Declare a graph as a member-variable/attribute. We will store here the names of the cities and the distances between them

    public void AddCity(string city)
    {
        //TODO #17: Add to the graph a node with the name of this city. This method will be called several times before calling CalculateDistances()
    }

    public void AddDistance(string fromCity, string toCity, double distance)
    {
        //TODO #18: Set the distance between these two cities in the graph. These cities should already be in the graph. This method will be called several times before calling CalculateDistances()
    }

    //TODO #19: Add GenericBinaryTree.cs to this project if you haven't done it already and uncomment the three methods below
    //TODO #20: Uncomment lines [285,321] in Common.Tests.cs. Comment line 323 in that file

    //public GenericBinaryTree<string, double> CalculateDistances(string fromCity)
    //{
    //      //TODO #21: Calculate the distance to each city in the graph from fromCity. The result is a binary tree where the key is the city and the value the distance
    //          a) Initialize variables: distanceToCity<string,double>, visited<string,bool> and nextCityCandidates<string,double>, currentCity
    //          b) While currentyCity != null
    //          b.1)    Find candidates for next step calculating (updating nextCityCandidates) -> USE CheckAdjacentNodes()
    //          b.2)    Select the next city (the one with the min distance in nextCityCandidates) and update currentCity -> USE ChooseNextUnvisitedCity()
    //}

    //private string ChooseNextUnvisitedCity(GenericBinaryTree<string, bool> visited, GenericBinaryTree<string, double> nextCityCandidates)
    //{
    //    //TODO #21: Choose the candidate with the minimum distance from nextCityCandidates that hasn't been visited yet
    //    return null;
    //}

    //private void CheckAdjacentNodes(GenericBinaryTree<string, double> distanceToCity, GenericBinaryTree<string, bool> visited,
    //    GenericBinaryTree<string, double> nextCityCandidates, string currentCity)
    //{
    //    //TODO #21: Add to nextCityCandidates all the neighbours of the currentCity, updating their distances in distanceToCity too
    //}

}