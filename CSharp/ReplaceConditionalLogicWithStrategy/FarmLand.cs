namespace ReplaceConditionalLogicWithStrategy;

internal abstract class YieldStrategyBase
{
    public abstract string Describe(TypeOfLand typeOfLand);
    public abstract double CalculateYield(TypeOfLand typeOfLand, int numberOfWorkers, int amountOfRain = 0);
}


internal class FieldStrategy : YieldStrategy
{
    public override string Describe(TypeOfLand typeOfLand) => "Field";
    
    public override double CalculateYield(TypeOfLand typeOfLand, int numberOfWorkers, int amountOfRain = 0)
    {
        const double baseYield = 2;
        
        if (amountOfRain > 10)
            return baseYield * 2;
        if (amountOfRain > 5)
            return baseYield;
        return baseYield / 2;
    }
}

internal class GardenStrategy : YieldStrategyBase
{
    public override string Describe(TypeOfLand typeOfLand) => "Garden";

    public override double CalculateYield(TypeOfLand typeOfLand, int numberOfWorkers, int amountOfRain = 0)
    {
        const double baseYield = 2;
        
        if (numberOfWorkers > 5)
            return baseYield * 10;
        return baseYield / 10;
    }
}

internal class OrchardStrategy : YieldStrategyBase
{
    public override string Describe(TypeOfLand typeOfLand) => "Orchard";

    public override double CalculateYield(TypeOfLand typeOfLand, int numberOfWorkers, int amountOfRain = 0)
    {
        const double baseYield = 2;

        if (numberOfWorkers > 2)
        {
            if (amountOfRain > 5)
                return baseYield * 5;
            return baseYield;
        }
        return 0;
    }
}

internal class YieldStrategy : YieldStrategyBase
{
    public override string Describe(TypeOfLand typeOfLand)
    {
        return "";
    }
    
    public override double CalculateYield(TypeOfLand typeOfLand, int numberOfWorkers, int amountOfRain = 0)
    {
        return 0;
    }
}


public class FarmLand
{
    private TypeOfLand _typeOfLand = TypeOfLand.Garden;
    private YieldStrategyBase _yieldStrategy = new GardenStrategy();

    public string Describe() => _yieldStrategy.Describe(_typeOfLand);

    public void SetType(TypeOfLand typeOfLand)
    {
        _typeOfLand = typeOfLand;
        if (typeOfLand == TypeOfLand.Field)
        {
            _yieldStrategy = new FieldStrategy();
        }
        else if (typeOfLand == TypeOfLand.Garden)
        {
            _yieldStrategy = new GardenStrategy();
        }
        else if (typeOfLand == TypeOfLand.Orchard)
        {
            _yieldStrategy = new OrchardStrategy();
        }
        else
        {
            _yieldStrategy = new YieldStrategy();
        }
    }

    public double CalculateYield(int numberOfWorkers, int amountOfRain = 0)
    {
        return _yieldStrategy.CalculateYield(_typeOfLand, numberOfWorkers, amountOfRain);
    }
}
