namespace CreationMethods;

internal static class Program
{
    private static void Main()
    {
        Teacher teacher = new Teacher(1, "John", true, "junior");
        Console.Write($"Hello {teacher.Name}!");
    }
}