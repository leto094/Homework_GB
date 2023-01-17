// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел

Console.WriteLine("введите количество строк");
int a = Convert.ToInt32(Console.ReadLine()); // преобразование чисоа в строку
Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк в столбце");
int c = Convert.ToInt32(Console.ReadLine()); // преобразование чисоа в строку

int[,,] array = new int[a, b, c];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = Convert.ToInt16(new Random().Next(1,99));
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) " );
        }
    }
    Console.WriteLine();
}