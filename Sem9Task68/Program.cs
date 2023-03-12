// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
int AckermannRec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannRec(m - 1, 1);
    }
    else
    {
        return AckermannRec(m - 1, AckermannRec(m, n - 1));
    }
}

int num1 = ReadData("Введите 1 неотрицательное число: ");
int num2 = ReadData("Введите 2 неотрицательное число: ");

if (num1 < 0 || num2 < 0) PrintData("1 или оба ввёденых чисел отрицательные");
else PrintData($"A({num1},{num2}) = {AckermannRec(num1,num2)}");



