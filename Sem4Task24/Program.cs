// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

// запрос данных у пользователя
int ReadDate(string line)
// выводим сообщение
{
  Console.Write(line);
  // считываем число
  int numberP= int.Parse(Console.ReadLine()??"0");
  // возвращаем значение
  return numberP;
}
// Методы вывода результата
void PrintResult(string line)
{
  Console.WriteLine(line);
}
long SumSimple(int numA)
{
  long sum=0;
  for(int i=1;i<=numA;i++)
  {
    sum+=i;
  }
  return sum;
}

long SumGausse(int numA)
{
  return((1+(long)numA)*(long)numA/2);
}
int numberA=ReadDate("Введите число А: ");
DateTime d1=DateTime.Now;
long res1=SumSimple(numberA);
Console.WriteLine(DateTime.Now-d1);

DateTime d2=DateTime.Now;
long res2=SumGausse(numberA);
Console.WriteLine(DateTime.Now-d2);
PrintResult("Сумма чисел от 1 до А ровна: "+res1);
PrintResult("Сумма чисел от 1 до А ровна: "+res2);