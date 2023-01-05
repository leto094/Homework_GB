// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число n");
int number = int.Parse(Console.ReadLine());

int index = 0;
int result = 0;

// int GetNumber(int value)
// {
//     int a = value / 100;
//     int b = (value / 10) % 10;
//     int c = value % 10;
    
//     result = a + b + c;
//     return result;

// }
// System.Console.WriteLine(GetNumber(number));

while (number > 9)
{
    result = result + (number % 10);
    number = number / 10;
}
result = result + number;
Console.WriteLine(result);