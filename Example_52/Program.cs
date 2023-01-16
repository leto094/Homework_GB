// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество n-строк");
int n = Convert.ToInt32(Console.ReadLine()); // преобразование чисоа в строку
Console.WriteLine("введите количество m-столбцов");
int m = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
FillArrayRandom(numbers);


void FillArrayRandom(double[,] array) // заполняем массив случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(1,99));
        }
    }
            
}

for (int j = 0; j < numbers.GetLength(1); j++) // нахождение среднеарифметическое по столбцам 
{
    double result = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        result = (result + numbers[i, j]);
    }
    result = Math.Round(result / n, 3);
    Console.Write(result + "; ");
}
Console.WriteLine();
PrintArray(numbers);


void PrintArray(double[,] array) // выводим массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("] ");
        Console.WriteLine("");
    }
}
