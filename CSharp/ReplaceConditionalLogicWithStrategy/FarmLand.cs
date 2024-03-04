namespace ReplaceConditionalLogicWithStrategy;

internal abstract class YieldStrategyBase
{
    public abstract string Describe();
    public abstract double CalculateYield(int numberOfWorkers, int amountOfRain = 0);
}


internal class FieldStrategy : YieldStrategyBase
{
    public override string Describe() => "Field";
    
    public override double CalculateYield(int numberOfWorkers, int amountOfRain = 0)
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
    public override string Describe() => "Garden";

    public override double CalculateYield(int numberOfWorkers, int amountOfRain = 0)
    {
        const double baseYield = 2;
        
        if (numberOfWorkers > 5)
            return baseYield * 10;
        return baseYield / 10;
    }
}

internal class OrchardStrategy : YieldStrategyBase
{
    public override string Describe() => "Orchard";

    public override double CalculateYield(int numberOfWorkers, int amountOfRain = 0)
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
    public override string Describe() => "";

    public override double CalculateYield(int numberOfWorkers, int amountOfRain = 0) => 0;
}


public class FarmLand
{
    private TypeOfLand _typeOfLand = TypeOfLand.Garden;
    private YieldStrategyBase _yieldStrategy = new GardenStrategy();

    public string Describe() => _yieldStrategy.Describe();

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
        return _yieldStrategy.CalculateYield(numberOfWorkers, amountOfRain);
    }
}
