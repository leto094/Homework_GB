// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Input m-number");
int m = Int32.Parse(Console.ReadLine());

Console.WriteLine("Input n-number");
int n = Int32.Parse(Console.ReadLine());

Console.WriteLine(SumNumbers(n, m));

int SumNumbers(int n, int m)
{
    if (n <= m)
    {
        return n;
    }
    return n + SumNumbers(n - 1, m);
}