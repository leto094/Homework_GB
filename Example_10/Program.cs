﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число от 100 до 999");
int n = Int32.Parse(Console.ReadLine());

int GetNumber(int value)
{
    int a = value / 100;
    int b = (value / 10) % 10;
    int c = value % 10;

    return b;
}

System.Console.WriteLine(GetNumber(n));