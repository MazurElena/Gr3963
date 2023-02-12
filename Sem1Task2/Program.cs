// Задача №2 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
  Console.WriteLine("Число А>B");
}
else
{
  Console.WriteLine("Число B>A");
}