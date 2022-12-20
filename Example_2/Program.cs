Console.WriteLine("Введите число a");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = Int32.Parse(Console.ReadLine());

if (a > b) 
{
    Console.Write("max = ");
    Console.Write(a);

    Console.Write(" min = ");
    Console.Write(b);

} 
else
{
    Console.Write("max = ");
    Console.Write(b);

    Console.Write(" min = ");
    Console.Write(a);

}
