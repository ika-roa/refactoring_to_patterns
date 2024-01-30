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

    public Teacher(int id, string name, string category) : this(id, name, true, category){}
    
    public static Teacher CreateSeniorTeacher(int id, string name, bool hasCar)
    {
        return new Teacher(id, name, hasCar, "senior");
    }

    public static Teacher CreateTeacherWithCar(int id, string name, string category)
    {
        return new Teacher(id, name, category);
    }
}