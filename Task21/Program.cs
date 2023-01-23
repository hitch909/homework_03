//  программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Distance AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 

Console.Clear();

Console.Write("введите координату точки A x=  ");
double Ax = int.Parse(Console.ReadLine()!);
Console.Write("введите координату точки A y=  ");
double Ay = int.Parse(Console.ReadLine()!);
Console.Write("введите координату точки A z=  ");
double Az = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("введите координату точки B x=  ");
double Bx = int.Parse(Console.ReadLine()!);
Console.Write("введите координату точки B y=  ");
double By = int.Parse(Console.ReadLine()!);
Console.Write("введите координату точки B z=  ");
double Bz = int.Parse(Console.ReadLine()!);
Console. WriteLine();

double result = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2) + Math.Pow((Az - Bz), 2));
double Result = Math.Round(result);
Console.WriteLine($"Расстояние мужду точками:  {Result}");
// Готово.
