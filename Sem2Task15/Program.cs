// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 
Console.Write("Введите число: ");
var day = Convert.ToInt32(Console.ReadLine());
string[] dayweek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if (day>0 && day<6)
{
  Console.WriteLine("Рабочий день "+dayweek[day-1]);
}
else
{
  Console.WriteLine("Выходной день "+dayweek[day-1]);
}
