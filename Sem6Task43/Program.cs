// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double K1=ReadData("Введите значение K1: ");
double B1=ReadData("Введите значение B1: ");
double K2=ReadData("Введите значение K2: ");
double B2=ReadData("Введите значение B2: ");

double ReadData(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}
(double x,double y) CrossPoint(double k1, double b1, double k2, double b2)
{
  double coorX1=(b2-b1)/(k1-k2);
  double coorY1=(k1*b2-k2*b1)/(k1-k2);
  return(coorX1,coorY1);
}
(double x,double y)pointA= CrossPoint(K1,B1,K2,B2);
PrintData($"Точка пересечения двух прямых: "+pointA);