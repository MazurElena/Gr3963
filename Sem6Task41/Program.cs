// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Метод ввода данных из консоли
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ??"0");
}
// Метод печати данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
// Метод подсчета положительных чисел
int CountNum(int numM)
{
  int res=0;
  for (int i = 0; i < numM; i++)
  {
    if (ReadData("")>0)
    {
      res++;
    }
  }
  return res;
}
int numerM=ReadData("Введите числа: ");
PrintData("Положительных чисел: ",CountNum(numerM));

