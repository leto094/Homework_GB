//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int length = ReadInt("Array length"); // объявим длину массива
int[] array = GetRandomArray(length, 1, 99); //объявляем параметры длины массива

PrintArray(array);
int result = Diff(array); // сумма элементов с нечетных мест

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");

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

// считаем разницу между максимальным и минимальным элементом массива int[]array

int Diff(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
        }
		
		if (array[i] > max) {
            max = array[i];
		}
	}

	return max - min;
}

// добавляем функцию вывода на экран

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}