// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа. 
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()??"0");
char[] digits = num.ToString().ToCharArray();
Console.WriteLine("Вторая цифра: "+int.Parse((digits[1]).ToString()));