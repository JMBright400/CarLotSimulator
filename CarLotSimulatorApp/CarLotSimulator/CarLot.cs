using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> DealerShip { get; set; } = new List<Car>();

        public void CheckCars()
        {
            foreach (Car car in DealerShip)
            {
                Console.WriteLine($"This is a {car.Make} {car.Model}, manufactured in {car.Year}.");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }
        }

    }
}
