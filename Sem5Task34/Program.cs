// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
int[] Gen1DArr(int len, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}
// Метод подсчета
int NumElemInRange(int[] arr)
{
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res++;
    }

    return res;
}



int[] mass = Gen1DArr(11, 100, 1000);
Print1DArr(mass);


WriteMess($"Четных чисел в массиве: {NumElemInRange(mass)}");

