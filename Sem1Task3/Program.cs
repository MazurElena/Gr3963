// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру

Console.Write("Введите число");
var day = Convert.ToInt32(Console.ReadLine());
if (day>0 && day<8)
{
  string[] dayweek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятницы", "Суббота", "Воскресенье"};
  Console.WriteLine(dayweek[day-1]);
}
else
{
  Console.WriteLine("Вы ввели не день недели!");
}