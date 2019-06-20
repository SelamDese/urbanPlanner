using System;
using System.Collections.Generic;

namespace urbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {     
// Build Your City
// Create several buildings in the Main() method of Program.cs.
// Give each building a width, height, and number of stories.

Building FiveOneTwo = new Building("512 8th Avenue"){
            Stories = 10,
            Width = 11.11,
            Depth = 22.22,
        };
        Building EightOneTwo = new Building("812 8th Street"){
            Stories = 11,
            Width = 12.12,
            Depth = 32.32
        };
        Building SixOneTwo = new Building("612 8th Avenue"){
            Stories = 12,
            Width = 13.13,
            Depth = 42.42
        };
// Construct each building.
// Have business people in your city purchase each of your buildings.
        
        FiveOneTwo.Construct();
        FiveOneTwo.Purchase("Andy");

        EightOneTwo.Construct();
        EightOneTwo.Purchase("Leah");
        
        SixOneTwo.Construct();
        SixOneTwo.Purchase("Jisie");

//add buildings to cities 

        City NashLav = new City("NashLav", "miki", new DateTime(2018-01-01));
        City NashSym = new City("NashLav", "Soli", new DateTime(2019-01-01));
        
        List<City> allCity = new List<City>();
        allCity.Add(NashLav);
        allCity.Add(NashSym);

        NashLav.BuildingLists.Add(FiveOneTwo);
        NashLav.BuildingLists.Add(EightOneTwo);


        NashSym.BuildingLists.Add(SixOneTwo);

// outputs the building info to the console to be inside a foreach loop that iterate the city's building collection.

        // foreach( City cityy in allCity)
        //     {
                foreach( Building building in NashLav.BuildingLists )
                {
                    // foreach(List<Building> building in Building)
                    // {
                        Console.WriteLine($"Building info");
                        Console.WriteLine($"--------------");
                        Console.WriteLine($"{building.Designer}");
                        Console.WriteLine($"{building.Owneer}");
                        Console.WriteLine($"{building.Volume}");
                    // }
                }
        }
    }
}
