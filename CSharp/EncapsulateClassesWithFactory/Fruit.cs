namespace EncapsulateClassesWithFactory;

public class Fruit
{
    public string Name { get; }
    public double Price { get; }

    public Fruit(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public static Apple CreateApple()
    {
        return new Apple();
    }
}

public class Apple : Fruit
{
    public Apple() : base("apple", 1){ }
}

public class Banana : Fruit
{
    public Banana() : base("banana", 2){ }
}


