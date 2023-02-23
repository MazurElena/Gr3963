// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.


// запрос данных у пользователя
using System.Numerics;
int ReadDate(string msg)
// выводим сообщение
{
  Console.Write(msg);
  // считываем число
  return(int.Parse(Console.ReadLine()??"0"));
}
// Метод вывода результата
void PrintAnswer(string msg)
{
  Console.WriteLine(msg);
}
BigInteger FactorialCalc(int numer)
{
  BigInteger fact=1;
  for(int i=2;i<=numer;i++)
  {
    fact*=i;
  }
  return fact;
}
int num=ReadDate("Введите чило: ");
PrintAnswer($"{num}!={FactorialCalc(num)}");