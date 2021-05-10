using NUnit.Framework;
using CarComsuption.Models;
using System.Collections.Generic;
using CarComsuption.Enums;

namespace TestOfCarProject
{
    public class Tests
    {
        private static List<Route> cityRoutes = new List<Route>()  {
                new Route()
                {
                    Distance = 100,
                    Type = TypeOfRoute.City
                }
            };

        private static List<Route> outOfCityRoutes = new List<Route>()  {
                new Route()
                {
                    Distance = 100,
                    Type = TypeOfRoute.OutOfCity
                }
            };

        private static List<Route> mixedRoutes = new List<Route>()  {
                new Route()
                {
                    Distance = 100,
                    Type = TypeOfRoute.OutOfCity
                },
                new Route()
                {
                    Distance = 200,
                    Type = TypeOfRoute.City
                }
            };

        [Test]
        public void TestOfCityRoute()
        {
            Route route = new Route();
            Car car = new Car();
            car.Type = TypeOfCar.Big;
            var expected = 9;
            var actual = route.CaluclateFuelBurned(cityRoutes, car);
            route.CaluclateFuelBurned(outOfCityRoutes, car);
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }

        [Test]
        public void TestOutOfCityRoute()
        {
            Route route = new Route();
            Car car = new Car();
            car.Type = TypeOfCar.Small;
            var expected = 7;
            var actual = route.CaluclateFuelBurned(outOfCityRoutes, car);
            route.CaluclateFuelBurned(outOfCityRoutes, car);
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }

        [Test]
        public void TestOfMixedRoutes()
        {
            Route route = new Route();
            Car car = new Car();
            car.Type = TypeOfCar.Big;
            var expected = 25;
            var actual = route.CaluclateFuelBurned(mixedRoutes, car);
            route.CaluclateFuelBurned(outOfCityRoutes, car);
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
    }
}