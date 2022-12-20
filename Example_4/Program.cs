Console.WriteLine("Введите число a");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число c");
int c = Int32.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);