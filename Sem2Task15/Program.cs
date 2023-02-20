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

// * Сделать вариант с использованием конструкции Dictionary
Dictionary <int, string> daysOfWeek = new Dictionary<int, string>();
daysOfWeek.Add(1, "Понедельник-Будний день");
daysOfWeek.Add(2, "Вторник-Будний день");
daysOfWeek.Add(3, "Среда-Будний день");
daysOfWeek.Add(4, "Четверг-Будний день");
daysOfWeek.Add(5, "Пятница-Будний день");
daysOfWeek.Add(6, "Суббота-Выходной день");
daysOfWeek.Add(7, "Воскресенье-Выходной день");
Console.Write("Введите число: ");
int dayOfWeek = int.Parse(Console.ReadLine()?? "0");
if(daysOfWeek.ContainsKey(dayOfWeek))
{
  Console.WriteLine(daysOfWeek[dayOfWeek]);
} 
else
{
  Console.WriteLine("Это не день недели");
}