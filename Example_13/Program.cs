// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число от 100 до 999");
int n = Int32.Parse(Console.ReadLine());

if ((99 < n) && (n < 1000))
{
    Console.WriteLine(n % 10);
    Console.WriteLine("Это успех!");
}   else {
    Console.WriteLine("Error");
}
    

