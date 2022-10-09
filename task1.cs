// 3найти мінімум з 4 цілочисельних чисел
using System; 
class Task1 {
        static void Main(string[] arg)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            Console.Write("Перше число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Друге число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третє число: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Четверте число: ");
            d = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                    {
                        Console.WriteLine("Найменше число: " + a);
                    }
                    else
                    {
                        Console.WriteLine("Найменше число: " + d);
                    }
                }
                else
                {
                    if (c < d)
                    {
                        Console.WriteLine("Найменше число: " + c);
                    }
                    else
                    {
                        Console.WriteLine("Найменше число: " + d);
                    }
                }
            }
            else
            {
                if (b < c)
                {
                    if (b < d)
                    {
                        Console.WriteLine("Найменше число: " + b);
                    }
                    else
                    {
                        Console.WriteLine("Найменше число: " + d);
                    }
                }
                else
                {
                    if (c < d)
                    {
                        Console.WriteLine("Найменше число: " + c);
                    }
                    else
                    {
                        Console.WriteLine("Найменше число: " + d);
                    }
                }
            }
            Console.ReadKey();
        }
    }
