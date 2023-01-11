// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int length = ReadInt("Array length"); // объявим длину массива
int[] array = GetRandomArray(length, 100, 999); //объявляем параметры длины массива
int result = 0;

PrintArray(array); // обозначили, что числа из массива должны быть выведенны на экран
SumResult(array); // покажет количество четных чисел в массиве

Console.WriteLine($"количество четных чисел в массиве: {result}");

//просьба ввести длинну массива = сколько чисел в нем должно быть:
int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

// создание функции, которая создаст заполненный массив, который будет принимать 
//длинну из максимальных и минимальных значений

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}
// добавляем функцию вывода на экран
// покажет количество чётных чисел в массиве

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

void SumResult(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0) 
        {
            result++;
        }
        
    }
}


