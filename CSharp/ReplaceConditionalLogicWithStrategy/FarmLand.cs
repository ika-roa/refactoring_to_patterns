namespace ReplaceConditionalLogicWithStrategy;

public class FarmLand
{
    private Type _type = Type.Garden;

    public string Describe()
    {
        if (_type == Type.Field)
            return "Field";
        if (_type == Type.Garden)
            return "Garden";
        if (_type == Type.Orchard)
            return "Orchard";
        return "";
    }

    public void SetType(Type type)
    {
        _type = type;
    }

    public double CalculateYield(int numberOfWorkers, int amountOfRain = 0)
    {
        const double baseYield = 2;
        double yield = 0;

        if (_type == Type.Field)
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

        if (_type == Type.Garden)
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

        if (_type == Type.Orchard)
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

public enum Type
{
    Field,
    Garden,
    Orchard
}