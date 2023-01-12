// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

Console.WriteLine("Введите координаты b1");
var b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты k1");
var k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты b2");
var b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты k2");
var k2 = int.Parse(Console.ReadLine());

double up_part = b2 - b1; 
double down_part = k1 - k2; 
double x = up_part / down_part;

double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых {x} и {y}");