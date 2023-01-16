// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.WriteLine("введите количество n-строк");
int n = Convert.ToInt32(Console.ReadLine()); // преобразование чисоа в строку
Console.WriteLine("введите количество m-столбцов");
int m = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
FillArrayRandom(numbers);
PrintArray(numbers);

void FillArrayRandom(double[,] array) // заполняем массив случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-99,99));
        }
    }
}

void PrintArray(double[,] array) // выводим массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}