// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine()??"0");
}
string LineBuilder(int num, int Pow)
{
  string res = string.Empty;
  for( int i=1; i<=num; i++)
  {
    res=res+Math.Pow(i, Pow)+"\t";
  }
  return res;
}
int N = ReadData("Введите конечное число: ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));