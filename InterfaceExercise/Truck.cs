using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string Year { get; set; } = "1990";

        public string Make { get; set; } = "Ford";

        public string Model { get; set; } = "F150";

        public double BedSize { get; set; } = 6.75;

        public int NumberOfWheels { get; set; } = 4;

        public double EngineSize { get; set; } = 4.6;

        public string FuelType { get; set; } = "87 Octane";

        public int SeatCount { get; set; } = 2;

        public string Motto { get; set; } = "Built Ford Tough";

        public string CompanyName { get; set; } = "Ford";

        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now reversing");
            }
            else
            {
                Console.WriteLine($"Can't reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in park");
            }
            else
            {
                Console.WriteLine($"Can't park until we change gears");
            }
        }

        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }

}
