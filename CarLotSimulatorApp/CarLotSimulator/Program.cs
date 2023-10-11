using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();

            Console.WriteLine($"Current number of vehicles: {CarLot._numberOfCars}");

            var ford = new Car();
            ford.Make = "Ford";
            ford.Model = "Focus";
            ford.Year = 2017;
            ford.EngineNoise = "vroom";
            ford.HonkNoise = "honk";
            ford.IsDriveable = true;

            Console.WriteLine($"Current number of vehicles: {CarLot._numberOfCars}");
            carLot.DealerShip.Add(ford);

            var chevy = new Car()
            {
                Make = "Chevy",
                Model = "Task Force",
                Year = 1958,
                EngineNoise = "grinding",
                HonkNoise = "beep",
                IsDriveable = false
            };
            Console.WriteLine($"Current number of vehicles: {CarLot._numberOfCars}");
            carLot.DealerShip.Add(chevy);

            var lotus = new Car(2021, "Lotus", "Evora GT", "roar", "honk honk", true);

            Console.WriteLine($"Current number of vehicles: {CarLot._numberOfCars}");
            carLot.DealerShip.Add(lotus);
   


            carLot.CheckCars();
        }
    }
}
