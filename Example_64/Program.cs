// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Input n-number");
int n = Int32.Parse(Console.ReadLine());

PrintNumber(n);

void PrintNumber(int n)
{
    Console.Write($"{n} ");
    if (n > 1){
        PrintNumber(n - 1);
    }
}
