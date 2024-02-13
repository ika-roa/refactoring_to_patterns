using FluentAssertions;

namespace EncapsulateClassesWithFactory.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var fruitBasket = new List<Fruit>
        {
            CreateApple(),
            new Banana(),
        };
        fruitBasket[0].Name.Should().Be("apple");
        fruitBasket[1].Price.Should().Be(2);
    }

    public static Apple CreateApple()
    {
        return new Apple();
    }
}