// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// запрос данных у пользователя
int ReadDate(string msg)
// выводим сообщение
{
  Console.WriteLine(msg);
  // считываем число
  return(int.Parse(Console.ReadLine()??"0"));
}
// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
// Функция вывода суммы цифр в числе
void PrintResult(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
int number = ReadDate("Введите число: ");
int len = NumberLen(number);
PrintResult(number, len);