// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
char[] digits = num.ToString().ToCharArray();
if( num>=100)
{
  Console.WriteLine("Третья цифра: "+int.Parse((digits[2]).ToString()));
}
else
{
  Console.WriteLine("Третьей цифры нет");
}
