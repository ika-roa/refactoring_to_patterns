namespace PolymorphicCreationWithFactory;

public interface IProducer
{
    void CreateFoodSourceIn(Location location);
    void Harvest(Product product);
    void Send(Product product);
}