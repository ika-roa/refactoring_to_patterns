namespace ReplaceConditionalLogicWithStrategy;

public class YieldStrategy
{
    public string Describe(TypeOfLand typeOfLand)
    {
        if (typeOfLand == TypeOfLand.Field)
            return "Field";
        if (typeOfLand == TypeOfLand.Garden)
            return "Garden";
        if (typeOfLand == TypeOfLand.Orchard)
            return "Orchard";
        return "";
    }
    
    public double CalculateYield(TypeOfLand typeOfLand, int numberOfWorkers, int amountOfRain = 0)
    {
        const double baseYield = 2;
        double yield = 0;

        if (typeOfLand == TypeOfLand.Field)
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

        if (typeOfLand == TypeOfLand.Garden)
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

        if (typeOfLand == TypeOfLand.Orchard)
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

public class FarmLand
{
    private TypeOfLand _typeOfLand = TypeOfLand.Garden;
    private YieldStrategy _yieldStrategy = new YieldStrategy();

    public string Describe() => _yieldStrategy.Describe(_typeOfLand);

    public void SetType(TypeOfLand typeOfLand)
    {
        _typeOfLand = typeOfLand;
        _yieldStrategy = new YieldStrategy();
    }

    public double CalculateYield(int numberOfWorkers, int amountOfRain = 0)
    {
        return _yieldStrategy.CalculateYield(_typeOfLand, numberOfWorkers, amountOfRain);
    }
}
