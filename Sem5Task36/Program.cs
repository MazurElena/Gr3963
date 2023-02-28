// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
// Метод подсчета нечетных элементов
int OldSum(int[]arr)
{
  int res =0;
  for(int i=1;i<arr.Length;i=i+2)
  {
    res=res+arr[i];
  }
  return res;
}
int[] testArr = Gen1DArr(12,10,100);
Print1DArr(testArr);

int res = OldSum(testArr);
PrintData("Сумма элементов на нечетных позициях: ",res);
