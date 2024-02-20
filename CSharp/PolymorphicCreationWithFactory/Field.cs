namespace PolymorphicCreationWithFactory;

public class Field
{
    private readonly Location _location;
    private readonly Farmer[] _farmers = { new("Adam"), new("Bob"), new("Charlie") };

    public Field(Location location)
    {
        _location = location;
    }

    public void GrowFood(Product product)
    {
        var randomIndex = new Random().Next(_farmers.Length);
        var farmer = _farmers[randomIndex];
        
        farmer.CreateFoodSourceIn(_location);
        farmer.Harvest(product);
        farmer.Send(product);
    }
}