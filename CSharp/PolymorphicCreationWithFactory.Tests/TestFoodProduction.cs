namespace PolymorphicCreationWithFactory.Tests;

public class Tests
{
    [Test]
    public void A_field_produces_food()
    {
        var fruit = new Product("Strawberry");
        var location = new Location("Munich");

        var field = new Field(location);
        field.GrowFood(fruit);
    }
}