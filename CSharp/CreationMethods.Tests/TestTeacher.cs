namespace CreationMethods.Tests;

public class Tests
{
    [Test]
    public void Test1()
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
}