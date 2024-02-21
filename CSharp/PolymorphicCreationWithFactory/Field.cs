namespace PolymorphicCreationWithFactory;

public abstract class FarmLand
{
    public abstract IProducer createProducer();
}

public class Field : FarmLand, IFarmLand
{
    private readonly Location _location;
    private readonly Farmer[] _farmers = { new("Adam"), new("Bob"), new("Charlie") };

    public Field(Location location)
    {
        _location = location;
    }

    public void GrowFood(Product product)
    {
        var farmer = createProducer();

        farmer.CreateFoodSourceIn(_location);
        farmer.Harvest(product);
        farmer.Send(product);
    }

    public override IProducer createProducer()
    {
        var randomIndex = new Random().Next(_farmers.Length);
        var farmer = _farmers[randomIndex];
        return farmer;
    }
}