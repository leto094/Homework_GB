//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int n = int.Parse(number);

if (n > 9999 && n < 100000)
{
   if (number[0] == number[4] && number[1] == number[3])
   {
      Console.WriteLine($"Число {number} является палиндромом");
   } else {
      Console.WriteLine($"Число {number} не является палиндромом");
   }
} else {
   Console.WriteLine("Вы ввели не пятизначное число");  
}


