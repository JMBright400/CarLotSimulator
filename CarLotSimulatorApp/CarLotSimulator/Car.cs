﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {

        public Car() 
        {
            CarLot._numberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

            CarLot._numberOfCars++;
        }


        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        { 
            EngineNoise = engineNoise;

            Console.WriteLine($"{Make} {Model} has an engine that sounds like {EngineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        { 
            HonkNoise = honkNoise;

            Console.WriteLine($"{Make} {Model} has a horn that sounds like {HonkNoise}.");
        }


    }
}
