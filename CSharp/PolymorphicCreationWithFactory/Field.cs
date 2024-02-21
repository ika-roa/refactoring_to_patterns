namespace PolymorphicCreationWithFactory;

public class Field : FarmLand
{
    private readonly Farmer[] _farmers = { new("Adam"), new("Bob"), new("Charlie") };

    public Field(Location location)
    {
        _location = location;
    }

    public override IProducer createProducer()
    {
        var randomIndex = new Random().Next(_farmers.Length);
        var farmer = _farmers[randomIndex];
        return farmer;
    }
}