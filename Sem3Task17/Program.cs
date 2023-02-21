// Напишите программу, которая принимает на вход координаты точки (х, у), при чем х не равен 0 и у не равен 0,
// и выдает номер четверти плоскости в которой находится эта точка.

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine()??"0");
}
// Метод определяет четверти по координатам точки
void PrintQutezTest(int x, int y)
{
  if(x>0&&y>0)Console.WriteLine("Точка в первой четверти");
  if(x>0&&y<0)Console.WriteLine("Точка во второй четверти");
  if(x<0&&y<0)Console.WriteLine("Точка в третьей четверти");
  if(x<0&&y>0)Console.WriteLine("Точка в четвертой четверти");
}
int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");
PrintQutezTest(coordX, coordY);