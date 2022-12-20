Console.WriteLine("Введите число n");
int n = Int32.Parse(Console.ReadLine());

int count = 1;

while(count < n+1)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count = count + 1;

}