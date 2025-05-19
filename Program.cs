// See https://aka.ms/new-console-template for more information
var availableOperators = new [] {"&", "|", "^"};
Console.WriteLine("Введите первое число");
if (int.TryParse(Console.ReadLine(), out int a))
{
    Console.WriteLine("Введите второе число");
    if (int.TryParse(Console.ReadLine(), out int b))
    {
        Console.WriteLine("Введите оператор & | или ^");
        var currentOperator = Console.ReadLine();
        if (availableOperators.Any(x => currentOperator == x.Trim()))
        {
            int result;
            switch (currentOperator)
            {
                case "&":
                    result =  a&b;
                    Console.WriteLine($"Результат: {result:D} {result:B} {result:X}");
                    break;
                case "|":
                    result =  a|b;
                    Console.WriteLine($"Результат: {result:D} {result:B} {result:X}");
                    break;
                case "^":
                    result =  a^b;
                    Console.WriteLine($"Результат: {result:D} {result:B} {result:X}");
                    break;
            }

            return;
        }
    }
}

Console.WriteLine("Error!"); // Ваш текст

