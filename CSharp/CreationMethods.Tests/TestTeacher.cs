namespace CreationMethods.Tests;

public class Tests
{
    [Test]
    public void TestStandardConstructor()
    {
        Teacher teacher = new(1, "Bob", true, "junior");
        Assert.Multiple(() =>
        {
            Assert.That(teacher.Id, Is.EqualTo(1));
            Assert.That(teacher.Name, Is.EqualTo("Bob"));
            Assert.That(teacher.HasCar, Is.EqualTo(true));
            Assert.That(teacher.Category, Is.EqualTo("junior"));
        });
    }
    
    [Test]
    public void TestConstructorForSeniorTeacher()
    {
        var teacher = CreateSeniorTeacher(1, "Bob", true);
        Assert.Multiple(() =>
        {
            Assert.That(teacher.Id, Is.EqualTo(1));
            Assert.That(teacher.Name, Is.EqualTo("Bob"));
            Assert.That(teacher.HasCar, Is.EqualTo(true));
            Assert.That(teacher.Category, Is.EqualTo("senior"));
        });
    }

    private static Teacher CreateSeniorTeacher(int id, string name, bool hasCar)
    {
        return new Teacher(id, name, hasCar);
    }

    [Test]
    public void TestConstructorForTeacherWithCar()
    {
        Teacher teacher = new(1, "Bob", "senior");
        Assert.Multiple(() =>
        {
            Assert.That(teacher.Id, Is.EqualTo(1));
            Assert.That(teacher.Name, Is.EqualTo("Bob"));
            Assert.That(teacher.HasCar, Is.EqualTo(true));
            Assert.That(teacher.Category, Is.EqualTo("senior"));
        });
    }
}