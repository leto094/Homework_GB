// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Hello!");

Console.WriteLine("Введите координаты Xb");
var xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Xa");
var xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Yb");
var yb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Ya");
var ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Ca");
var ca = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Cb");
var cb = int.Parse(Console.ReadLine());

double result = 0;

result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(cb - ca, 2));

Console.WriteLine(Math.Round(result, 3));
