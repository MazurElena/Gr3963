// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

// запрос данных у пользователя
int ReadDate(string msg)
// выводим сообщение
{
  Console.WriteLine(msg);
  // считываем число
  return(int.Parse(Console.ReadLine()??"0"));
}
// считываем число
int numberOfDigits(int num)
{
  return(int) (Math.Floor(Math.Log10(num)))+1;
}
// Метод вывода результата
void PrintAnswer(string explain, int num)
{
  Console.WriteLine(explain+num);
}
int num=ReadDate("Введите чило: ");
PrintAnswer("Количество цифр в числе: ", numberOfDigits(num));