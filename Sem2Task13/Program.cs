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

// * Сделать вариант для числа длиной до 10 цифр не используя char или string
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitCount = (int)Math.Floor(Math.Log10(number)+1);
if (digitCount<3)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  int thirdDigit = (int)(number/Math.Pow(10, digitCount-3))%10;
  Console.WriteLine($"Третья цифра: {thirdDigit}");
}