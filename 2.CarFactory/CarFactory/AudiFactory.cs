namespace CarFactory
{
    public class AudiFactory : ICarFactory
    {
        public ICarcase CreateCarcase() => new AudiCarcase();

        public IEngine CreateEngine() => new AudiEngine();

        public ICarInterior CreateInterior() => new AudiInterior();
    }
}