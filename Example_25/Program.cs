// Напишите цикл (программу?), который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("введите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("введите число B");
int B = int.Parse(Console.ReadLine());

double result = Math.Pow(A,B);

Console.WriteLine($"число А = {A} в степени B = {B} равно {result}");