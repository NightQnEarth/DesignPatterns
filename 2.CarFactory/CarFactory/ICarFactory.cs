namespace CarFactory
{
    public interface ICarFactory
    {
        ICarcase CreateCarcase();
        IEngine CreateEngine();
        ICarInterior CreateInterior();
    }
}