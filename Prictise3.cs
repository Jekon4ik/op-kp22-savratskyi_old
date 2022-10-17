//Трикутник Паскаля
using System;
namespace Program
{
    class Practise3
    {
        public static void Main()
        {
            int rows;
            int val = 1;
            int blank;
            int i;
            int j;
            // Запитуємо кількість рядків та перевріяємо 
            // правильність введеного значення
            do
            {
                Console.WriteLine("Введiть значення(кiлькiсть рядкiв) вiд 1 до 9");
                rows = Convert.ToInt32(Console.ReadLine());
            } while (rows > 9 || rows < 1);
            // цикл для визначення пробілів
            for (i = 0; i < rows; i++)
            {
                for (blank = 1; blank <= rows - i; blank++)
                    Console.Write(" ");
                // цикл знаходження значення
                for (j = 0; j <= i; j++)
                {
                    //властивість трикутника паскаля, за якою ми знаходимо
                    //значення
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                //створення нового рядка
                Console.WriteLine();
            }
        }
    }
}
