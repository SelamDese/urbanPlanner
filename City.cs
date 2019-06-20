using System;
using System.Collections.Generic;

namespace urbanPlanner
{
    class City {
// Name of the city.
        public string Name { get; set; } 
// The mayor of the city.
        public string Mayor { get; set; }
// Year the city was established.
        public DateTime YearEstablished { get; set; }
// A collection of all of the buildings in the city.
        public List<Building> BuildingLists { get; set; } = new List<Building>();
        
// A method to add a building to the city.

        public City(string name, string mayor, DateTime yearEstablished)
        {
            Name = name;
            Mayor = mayor;
            YearEstablished = yearEstablished;
        }
        public void AddBuilding(Building buildingg)
        {
            BuildingLists.Add(buildingg);
        }
    }
}