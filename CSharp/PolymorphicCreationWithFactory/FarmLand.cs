namespace PolymorphicCreationWithFactory;

public abstract class FarmLand : IFarmLand
{
    protected Location _location;
    public abstract IProducer createProducer();

    public void GrowFood(Product product)
    {
        var producer = createProducer();

        producer.CreateFoodSourceIn(_location);
        producer.Harvest(product);
        producer.Send(product);
    }
}