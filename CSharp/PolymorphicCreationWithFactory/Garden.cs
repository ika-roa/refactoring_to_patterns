namespace PolymorphicCreationWithFactory;

public class Garden : FarmLand, IFarmLand
{
    private readonly Gardener[] _gardeners = { new("Delilah"), new("Emily"), new("Fiona") };

    public Garden(Location location)
    {
        _location = location;
    }

    public override IProducer createProducer()
    {
        var randomIndex = new Random().Next(_gardeners.Length);
        var gardener = _gardeners[randomIndex];
        return gardener;
    }
}