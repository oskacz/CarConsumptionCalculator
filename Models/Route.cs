using CarComsuption.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarComsuption.Models
{
    public class Route : IRoute
    {
        public int Distance { get; set; }

        public TypeOfRoute Type { get; set; }

        public decimal CaluclateFuelBurned(IEnumerable<Route> segments, Car car)
        {
            var consumption = 0;

            foreach (var segment in segments)
            {
                if (segment.Type == Enums.TypeOfRoute.City)
                    consumption = consumption + segment.Distance * 9 / 100;

                if (segment.Type == Enums.TypeOfRoute.OutOfCity)
                    consumption = consumption + segment.Distance * 7 / 100;
            }
            Console.WriteLine($"Samochód typu {car.Type} spali: {consumption}");

            return consumption;
        }
    }
}
