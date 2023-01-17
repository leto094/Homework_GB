// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
    
Console.WriteLine("input number a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("input number b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(akkermanFunction(a,b));


int akkermanFunction(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return akkermanFunction(m - 1, 1);
    }
    return akkermanFunction(m - 1, akkermanFunction(m, n - 1));
}