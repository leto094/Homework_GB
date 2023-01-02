// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void FillArray(int [] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 8);
        index++;
    }

}

void PrintArray(int[] dates)
{
    int count = dates.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(dates[position]);
        Console.Write(" ");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);