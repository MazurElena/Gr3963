// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int RecSumDigMN(int m, int n)
{
     if (m >= n)
    {
        return n;
    }
    else
    {
        return m + RecSumDigMN(m + 1, n);
    }
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int result = number1<number2?RecSumDigMN(number1, number2):RecSumDigMN(number2, number1);
PrintResult(result);