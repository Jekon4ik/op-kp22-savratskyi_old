// Знайти площу трикутника за формулою Герона.
using System;
class Task1
{
    static void Main(string[] arg)
    {
Console.Write("Перша сторона трикутника: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Друга сторона трикутника: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Третя сторона трикутника: ");
double c = Convert.ToDouble(Console.ReadLine());
double p = (a + b + c) / 2;
Console.WriteLine("Площа трикутника: " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));

Console.ReadKey();
    }
}
