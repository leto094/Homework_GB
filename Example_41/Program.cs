// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Input M-numbers:\t");
int elements = int.Parse(Console.ReadLine()); // попросили пользователя ввести длину массива

int[] array = new int[elements]; // Обозначили, что массив будет состоять из того кол-ва элементов, которео ввелпользователь
for (int i = 0; i < array.Length; i++) // просьба ввести числа для заполнения массива. Заполнение самого массива нужным кол-вом элементов
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    array[i] = int.Parse(Console.ReadLine());
}

int gtZeroCount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        Console.WriteLine($"{array[i]} больше 0");
        gtZeroCount ++;
    } else {
        Console.WriteLine($"{array[i]} меньше 0");
    }
}

Console.WriteLine($"Cтолько чисел больше 0: {gtZeroCount}");
