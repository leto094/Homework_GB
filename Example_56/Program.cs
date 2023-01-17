// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine()); // преобразование чисоа в строку
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
FillArrayRandom(numbers);
PrintArray(numbers);

int minSumRow = findMinSumArrayRow(numbers);

Console.WriteLine($"Строка с наименьшей суммой {minSumRow + 1}");

void FillArrayRandom(double[,] array) // заполняем массив случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(1,10));
        }
    }
}

// Нахождение строки с наименьшей суммой элементов

int findMinSumArrayRow(double[,] array)
{
    int result = 0;
    double minSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        } 
        
        if (i == 0) {
            minSum = sum; 
        }

        if (sum < minSum) {
            minSum = sum;
            result = i;
        }
    }

    return result;
}

// Вывод массива на экран

void PrintArray(double[,] array) 
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