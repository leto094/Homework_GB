// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine()); // преобразование чисоа в строку
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
FillArrayRandom(numbers);

Console.WriteLine("Было");

PrintArray(numbers);

Console.WriteLine("Стало");

numbers = SortArray(numbers);
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

// упорядочим по убыванию элементы каждой строки двумерного массива

double[,] SortArray(double[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, i] < array[k, j])
                {
                    double swop = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = swop; 
                }
            }
        }
    } 
    return array; 
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