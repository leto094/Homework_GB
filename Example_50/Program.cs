// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("введите количество n-строк");
int n = Convert.ToInt32(Console.ReadLine()); // преобразование чисоа в строку
Console.WriteLine("введите количество m-столбцов");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите искомое значение");
int element = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
FillArrayRandom(numbers);
PrintArray(numbers);
CheckNumber(numbers, element);
 

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

// проверка на наличие элемента в массиве

bool CheckNumber (double[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( array[i, j] == number)
            {
                Console.Write($"Число {element} присутствует в массиве");
                Console.Write("");
                return true;
            } 
        }
    }
    
    Console.Write($"Число {element} не присутствует в массиве");
    return false; 
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
