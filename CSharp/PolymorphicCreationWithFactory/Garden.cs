namespace PolymorphicCreationWithFactory;

public class Garden
{
    private readonly Location _location;
    private readonly Gardener[] _gardeners = { new("Delilah"), new("Emily"), new("Fiona") };

    public Garden(Location location)
    {
        _location = location;
    }
    
    public void GrowFood(Product product)
    {
        var gardener = createProducer();

        gardener.CreateFoodSourceIn(_location);
        gardener.Harvest(product);
        gardener.Send(product);
    }

    public Gardener createProducer()
    {
        var randomIndex = new Random().Next(_gardeners.Length);
        var gardener = _gardeners[randomIndex];
        return gardener;
    }
}