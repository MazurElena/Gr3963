﻿// Задача №0
// Напишите программу, которая на вход принимает число и выдаёт 
// его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число: ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем чтобы данные не были пустыми
if(inputNum != null)
{
  //Парсим введеное число
  int number = int.Parse(inputNum);

  //Находим квадрат числа
  //int outNum = number*number;
  int outNum = (int)Math.Pow(number,2);

  //Выводим данные в консоль
  Console.WriteLine("Квадрат числа: "+outNum);
}