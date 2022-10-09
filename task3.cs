//За координатами двох точок( x1; y1) (x2; y2) знайти модуль вектора(його довжину)
using System;
class Task1
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Кординати першої точки: ");
        Console.Write("x: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Кординати другої точки: ");
        Console.Write("x: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        double x3 = x2 - x1;
        double y3 = y2 - y1;
        double modul = Math.Sqrt(x3 * x3 + y3 * y3);
        Console.WriteLine("Довжина вектора: " + modul);

        Console.ReadKey();
    }
}
