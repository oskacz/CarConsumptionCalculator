using System;
using System.Collections.Generic;
using System.Text;

namespace CarComsuption.Models
{
    public interface IRoute
    {
        public decimal CaluclateFuelBurned(IEnumerable<Route> segments, Car car);
    }
}
