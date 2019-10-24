namespace CarFactory
{
    public class BmwFactory : ICarFactory
    {
        public ICarcase CreateCarcase() => new BmwCarcase();

        public IEngine CreateEngine() => new BmwEngine();

        public ICarInterior CreateInterior() => new BmwInterior();
    }
}