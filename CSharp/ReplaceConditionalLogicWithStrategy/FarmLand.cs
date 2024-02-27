﻿namespace ReplaceConditionalLogicWithStrategy;

public class Yieldstrategy
{
    
}

public class FarmLand
{
    private TypeOfLand _typeOfLand = TypeOfLand.Garden;

    public string Describe()
    {
        if (_typeOfLand == TypeOfLand.Field)
            return "Field";
        if (_typeOfLand == TypeOfLand.Garden)
            return "Garden";
        if (_typeOfLand == TypeOfLand.Orchard)
            return "Orchard";
        return "";
    }

    public void SetType(TypeOfLand typeOfLand)
    {
        _typeOfLand = typeOfLand;
    }

    public double CalculateYield(int numberOfWorkers, int amountOfRain = 0)
    {
        const double baseYield = 2;
        double yield = 0;

        if (_typeOfLand == TypeOfLand.Field)
        {
            if (amountOfRain > 10)
            {
                yield = baseYield * 2;
            }
            else if (amountOfRain > 5)
            {
                yield = baseYield;
            }
            else
            {
                yield = baseYield / 2;
            }
        }

        if (_typeOfLand == TypeOfLand.Garden)
        {
            if (numberOfWorkers > 5)
            {
                yield = baseYield * 10;
            }
            else
            {
                yield = baseYield / 10;
            }
        }

        if (_typeOfLand == TypeOfLand.Orchard)
        {
            if (numberOfWorkers > 2)
            {
                if (amountOfRain > 5)
                {
                    yield = baseYield * 5;
                }
                else
                {
                    yield = baseYield;
                }
            }
            else
            {
                yield = 0;
            }
        }

        return yield;
    }
}
