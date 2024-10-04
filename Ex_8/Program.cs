using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть довжини сторін трикутника:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double longest = Math.Max(a, Math.Max(b, c));
        Console.WriteLine($"Найдовша сторона: {longest}");
    }
}
