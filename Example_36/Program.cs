// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int length = ReadInt("Array length"); // объявим длину массива
int[] array = GetRandomArray(length, -10, 99); //объявляем параметры длины массива


PrintArray(array); // обозначили, что числа из массива должны быть выведенны на экран
int result = SumArray(array); // сумма элементов с нечетных мест

Console.WriteLine($"сумма элементов на нечетных позициях: {result}");

//просьба ввести длинну массива = сколько чисел в нем должно быть:
int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

// создание функции, которая создаст заполненный массив, который будет принимать 

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
	Random random = new Random();

	for(int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

// вывод на экран массив

void PrintArray(int[] array)
{
	for(int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

// найти сумму элементов на нечетных позициях

int SumArray(int[] array)
{
    int res = 0;
    for(int i=1; i < array.Length; i+=2)
    {
        res += array[i];
    }

    return res; 
}


