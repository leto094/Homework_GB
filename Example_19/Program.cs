//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int n = Int32.Parse(text);
string text = Console.ReadLine();

while ((n > 9999) && (n < 100000))
{
   if (n [0] == n [4] && n [1]== n [3]){
    Console.WriteLine("Число {n} является палиндромом");
   }

 else{
    Console.WriteLine("Error");}

}