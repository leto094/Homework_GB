// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

int index = 1;

while (index <= n)
{
    Console.Write(Math.Pow(index, 3));
    if (index != n) 
    {
        Console.Write(", ");
    }
    index++;
}
