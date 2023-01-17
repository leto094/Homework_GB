// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int m, int n)
{
	if(m == 0)
	{
		return n + 1;
	}
	if(m > 0 && n == 0)
	{
		return AkkermanFunc(m - 1, 1);
	}
	return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
	
Console.WriteLine("input number a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("input number b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(AkkermanFunc(3,2));
// if (a == 3 && b == 2)
// {
//     Console.WriteLine(" ");
//     Console.WriteLine(AkkermanFunc(3,2));
// } else {
//     Console.WriteLine(" ");
//     Console.WriteLine(AkkermanFunc(2,3));
// }
