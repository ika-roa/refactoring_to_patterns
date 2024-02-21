namespace PolymorphicCreationWithFactory;

public interface IFarmLand
{
    void GrowFood(Product product);
    IProducer createProducer();
}