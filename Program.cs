int[] fibonacci = new int[10];
fibonacci[1] = 1;
for (var i = 2; i < fibonacci.Length; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}
Console.WriteLine($"Fibonacci: {String.Join(" ", fibonacci)}");

Console.Write("Second: ");
for (var i = 2; i <= 20; i+=2)
{ 
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.WriteLine("Table: ");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{i*j} ");
    }
    Console.WriteLine();
}

var password = "qwerty";
var value = "";
do
{
    value = Console.ReadLine();
} while (value != password);
Console.WriteLine("Password correct!");

