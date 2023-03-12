// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string LineGenRec(int num)
{   
      if (num == 1)
    {
      return "1";
    }
    else
    {
        LineGenRec(num - 1);
        return LineGenRec(num - 1) + " " + num.ToString();
    }
}

int number = ReadData("Введите число N: ");
string str = LineGenRec(number);
Console.WriteLine(str);