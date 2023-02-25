// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// // и возводит число A в натуральную степень B.

// // запрос данных у пользователя
int ReadDate(string msg)
// выводим сообщение
{
  Console.WriteLine(msg);
  // считываем число
  return(int.Parse(Console.ReadLine()??"0"));
}

// Метод возведения в степень
void PrintData(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
int numA=ReadDate("Введите первое число: ");
int numB=ReadDate("Введите второе число: ");
PrintData(numA, numB);

