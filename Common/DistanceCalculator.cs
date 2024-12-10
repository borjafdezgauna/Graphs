using System;
using Common;


public class DistanceCalculator
{
    //TODO #28: Declare a graph as a member-variable/attribute. We will store here the names of the cities and the distances between them
    

    public void AddCity(string city)
    {
        //TODO #29: Add to the graph a vertex with the name of this city. This method will be called several times before calling CalculateDistances()
        
    }

    public void AddDistance(string fromCity, string toCity, double distance)
    {
        //TODO #30: Set the distance between these two cities in the graph. These cities should already be in the graph. This method will be called several times before calling CalculateDistances()
        
    }

    
    
    public IDictionary<string, double> CalculateDistances(string fromCity)
    {
        //TODO #31: Add one of the two dictionary classes to this project before implementing this method
        //Calculate the distance to each city in the graph from fromCity.The result is a binary tree where the key is the city and the value the distance
        //          a) Initialize variables: distanceToCity<string,double>, visited<string,bool> and nextCityCandidates<string,double>, currentCity
        //          b) While currentyCity != null
        //          b.1)    Find candidates for next step calculating (updating nextCityCandidates) -> USE CheckNeighbours()
        //          b.2)    Select the next city (the one with the min distance in nextCityCandidates) and update currentCity -> USE ChooseNextUnvisitedCity()
        
        return null;
        
    }

    private string ChooseNextUnvisitedCity(IDictionary<string, bool> visited, IDictionary<string, double> nextCityCandidates)
    {
        //TODO #32: Choose the candidate with the minimum distance from nextCityCandidates that hasn't been visited yet
        
        return null;
        
    }

    private void CheckNeighbours(IDictionary<string, double> distanceToCity, IDictionary<string, bool> visited,
        IDictionary<string, double> nextCityCandidates, string currentCity)
    {
        //TODO #33: Add to nextCityCandidates all the neighbours of the currentCity, updating their distances in distanceToCity too
        
    }
}