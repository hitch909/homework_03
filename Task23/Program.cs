// программа, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("введите любое число  ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("введите верхий предел таблицы  ");
int max = int.Parse(Console.ReadLine()!);
int min = 1;

Console.WriteLine();
Console.WriteLine($"Таблица кубов числа {number}:");
while (min <= max)
{
    double result = Math.Pow(min, 3);
    
    Console.Write($" {result} ");
    min++;
}
// готово.
