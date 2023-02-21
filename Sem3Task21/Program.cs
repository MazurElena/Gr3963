﻿// Напишите программу, которая принимает  на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine()??"0");
}

// Метод выводит данные пользователя
void PrintData(string msg, double val)
{
  Console.WriteLine(msg + val);
}

// Метод находит расстояние между точками на плоскости
double Calchen2D(int x1, int x2, int y1, int y2, int z1, int z2)
{
  return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
}
int x1 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату У точки А: ");
int x2 = ReadData("Введите координату Х точки В: ");
int y2 = ReadData("Введите координату У точки В: ");
int z1 = ReadData("Введите координату Z точки А: ");
int z2 = ReadData("Введите координату Z точки В: ");
double res = Calchen2D(x1, x2, y1, y2, z1, z2);
PrintData("Растояние между точками А и В: ", res);
