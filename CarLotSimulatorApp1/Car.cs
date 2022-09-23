using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarLotSimulatorApp1
{
    public class Car
    {
        public Car() 
        {
            CarLot.NumberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            CarLot.NumberOfCars++;

            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"The {Model} has an engine that achieves {EngineNoise}.");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"The {Model} has an engine that achieves {HonkNoise}.");
        }
    }
}
