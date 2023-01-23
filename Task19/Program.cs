// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("введите любое целое число :  ");
int number = int.Parse(Console.ReadLine()!);
int result = 0;
int x = 0;
int y = number;
while ( y > 0)
{
    x = y % 10;
    result = result * 10 + x;
    y = y / 10;
}
if ( number == result) Console.Write("введенное число является палиндромом.");
else
{
    Console.Write("введенное число НЕ является палиндромом.");
}
// готово.