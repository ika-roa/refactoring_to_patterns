namespace CreationMethods;

public class Teacher
{
    public int Id { get; }
    public string Name { get; }
    public bool HasCar { get; }
    public string Category { get; }

    public Teacher(int id, string name, bool hasCar, string category)
    {
        Id = id;
        Name = name;
        HasCar = hasCar;
        Category = category;
    }
    
    public Teacher(int id, string name, bool hasCar)
    {
        Id = id;
        Name = name;
        HasCar = hasCar;
        Category = "senior";
    }
    
    public Teacher(int id, string name, string category)
    {
        Id = id;
        Name = name;
        HasCar = true;
        Category = category;
    }
}