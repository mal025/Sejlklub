using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    public class Boat
    {
        public int Capacity { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public int SailNumber { get; set; }
        public string MotorInformation { get; set; }
        public string Measurements { get; set; }
        public int BuildYear { get; set; }
        public string Description { get; set; }
        public Boat() 
        { 
        }

        public Boat(int capacity, string name, int id, string type, string model, int sailNumber,
                string motorInformation, string measurements, int buildYear, string description)
        {
            Capacity = capacity;
            Name = name;
            ID = id;
            Type = type;
            Model = model;
            SailNumber = sailNumber;
            MotorInformation = motorInformation;
            Measurements = measurements;
            BuildYear = buildYear;
            Description = description;
        }
    }
}
