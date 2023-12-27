using System;
class Program
{
    static void Main()
    {

        // script 

        Console.WriteLine("Script kakoy-to 0_0");

        //


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
