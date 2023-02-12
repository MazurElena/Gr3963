// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
Console.Write("Введите число");
string? inputLine = Console.ReadLine();
if (inputLine!= null)
{
  int inputNumber = int.Parse(inputLine);
  int startNumber = inputNumber*(-1);
  string outLine = string.Empty;
  while(startNumber<inputNumber)
  {
    outLine = outLine + startNumber + ", ";
    startNumber ++;
  }
  outLine = outLine + inputNumber;
  Console.WriteLine(outLine);
}