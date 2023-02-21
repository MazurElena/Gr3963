// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int result = int.Parse(Console.ReadLine()??"0");
  return result;
}
// Проводим тест на палиндромность
int num = ReadData("Введите пятизначное число");
if((num/10000==num%10) && (num/1000%10==num/10%10)) 
{
  Console.WriteLine("Число является палиндромом");
}
else Console.WriteLine("Число не является палиндромом");
