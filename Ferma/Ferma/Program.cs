using System;


class Tests
{
    readonly int Void;
    readonly int Void2;
    readonly int Void3;
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Теорема Пифагора");

        Console.Write("Первый катет: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Второй катет: ");
        double b = double.Parse(Console.ReadLine());

        double cSquared = a * a + b * b;

        Console.WriteLine($"Квадрат гипотенузы: {cSquared}");
        Console.WriteLine($"Сумма квадратов катетов: {a * a + b * b}");

        if (cSquared == a * a + b * b)
        {
            Console.WriteLine("Теорема подтверждена");
        }
        else
        {
            Console.WriteLine("Теорема не выполняется");
        }
    }
}
