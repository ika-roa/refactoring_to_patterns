namespace PolymorphicCreationWithFactory;

internal record Gardener
{
    private readonly string _name;

    public Gardener(string name)
    {
        _name = name;
    }

    public void CreateFoodSourceIn(Location location) => Console.WriteLine($"{_name} plants a garden in {location}.");
    public void Harvest(Product product) => Console.WriteLine($"{_name} harvests {product} from garden.");
    public void Send(Product product) => Console.WriteLine($"{_name} sends {product} to the market.");
}