﻿namespace EncapsulateClassesWithFactory;

public class Fruit
{
    public string Name { get; }
    public double Price { get; }

    public Fruit(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public static Fruit CreateApple()
    {
        return new Apple();
    }

    public static Fruit CreateBanana()
    {
        return new Banana();
    }
}

internal class Apple : Fruit
{
    public Apple() : base("apple", 1){ }
}

internal class Banana : Fruit
{
    public Banana() : base("banana", 2){ }
}


