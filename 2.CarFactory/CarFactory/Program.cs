using System;

namespace CarFactory
{
    static class Program
    {
        private static void Main()
        {
            var carFactories = new ICarFactory[] { new BmwFactory(), new AudiFactory() };

            foreach (var carFactory in carFactories)
                Console.WriteLine(BuildCar(carFactory));
        }

        private static string BuildCar(ICarFactory carFactory) =>
            string.Concat(carFactory.CreateCarcase().Carcase, carFactory.CreateEngine().Engine,
                          carFactory.CreateInterior().CarInterior);
    }
}