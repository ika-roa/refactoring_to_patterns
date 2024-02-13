using FluentAssertions;

namespace EncapsulateClassesWithFactory.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var fruitBasket = new List<Fruit>
        {
            Fruit.CreateApple(),
            new Banana(),
        };
        fruitBasket[0].Name.Should().Be("apple");
        fruitBasket[1].Price.Should().Be(2);
    }
}