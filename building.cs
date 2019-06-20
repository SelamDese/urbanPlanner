using System;

namespace urbanPlanner
{
    public class Building
    {
// Private Fields
// _designer of type string. It will hold your name.
        private string _designer = "Selam";
        public string Designer
        {
                get 
                {
                        return _designer;
                }
        }
// _dateConstructed of type DateTime. This will hold the exact time the building was created.
        private DateTime _dateConstructed { get; set; }
// _address of type string.
        private string _address { get; }
// _owner of type string. This will store the same of the person who owns the building.
        private string _owner { get; set; }
        public string Owneer
        {
                get 
                {
                        return _owner;
                }
        }

// Public Properties
// Stories typed as an integer.
        public int Stories { get; set; }
// Width typed as a double.
        public double Width { get; set; }
// Depth typed as a double.
        public double Depth { get; set; }
// Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
        public double Volume 
            { 
                get
                    {
                        return Width * Depth * (3 * Stories);
                    } 
            }

// Constructor
// Define a constructor method that accepts a single string argument - address - 
// so that you can send as a parameter when you create each instance with new Building("800 8th Street");
// The constructor's logic should set the _address field's value to the argument value
        public Building(string address)
        {
            _address = address;
        }
// Public Methods
// Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
        public void Construct()
        {
           _dateConstructed = DateTime.Now; 
        }
// Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. 
// The method should take that string and assign it to the private _owner field.
// Neither of these methods will return a value.
        public void Purchase(string owner)
        {
            _owner = owner;
        }
    }
}