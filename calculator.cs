double num1 = 0;
double num2 = 0;
double result = 0;
String znak;

do
{
    Console.WriteLine("------------------------");
    Console.WriteLine("       КАЛЬКУЛЯТОР      ");
    Console.WriteLine("------------------------");



    Console.Write("Введiть число 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введiть число 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Виберiть арифметичну дiю: ");
    Console.WriteLine("\t+ : Додавання");
    Console.WriteLine("\t- : Вiднiмання");
    Console.WriteLine("\t* : Множення");
    Console.WriteLine("\t/ : Дiлення");
    Console.WriteLine("\t^ : Пiднесення до степеня");
    Console.Write("Виберiть арифметичну дiю: ");

    znak = Console.ReadLine();


    switch (znak)
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine("Результат: " + num1 + " + " + num2 + " = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine("Результат: " + num1 + " - " + num2 + " = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine("Результат: " + num1 + " * " + num2 + " = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine("Результат: " + num1 + " / " + num2 + " = " + result);
            break;
        case "^":
            result = Math.Pow(num1, num2);
            Console.WriteLine("Результат: " + num1 + "^" + num2 + " = " + result);
            break;
    }
    Console.WriteLine("Хочете продовжити?(Т = Так, Н = Нi)");
} while (Console.ReadLine().ToUpper() == "Т");
Console.ReadKey();