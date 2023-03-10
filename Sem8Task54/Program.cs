// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Метод, принимающий данные из консоли
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    string inStr = Console.ReadLine() ?? "0"; inStr = inStr.Replace(',', '.');
    return (int.Parse(inStr));
}
// Метод генерирующий массив
int[,] Gen2DArr(int countRow, int countCol, int min, int max)
{
    if (min > max) //to ensure min<max
    {
        int temp = min; min = max; max = temp;
    }
    int[,] arr = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}
// Метод, выводящий на печать массив
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)];
            Console.Write($"{arr[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
// Метод упорядочивания по убыванию элементов каждой строки
void Sort2DArr(int[,]arr)
{
  int[]row=new int[arr.GetLength(1)];
  for(int i=0;i<arr.GetLength(0);i++)
  {
    for(int j=0;j<row.Length;j++)
    {
      row[j]=arr[i,j];
    }
    BubbleSort(row);
    for(int j=0;j<row.Length;j++)
    {
      arr[i,j]=row[j];
    }
  }
}
// Метод сортировки пузырьком
int[] BubbleSort(int[]arr)
{
    int[] result = arr;
    int arrlen = result.Length;
    int buf = result[0];
    for (int j = 0; j < arrlen; j++)
    {
        for (int i = 0; i < arrlen - 1 - j; i++)
        {
            if (result[i] < result[i + 1])
            {
                buf = result[i + 1];
                result[i + 1] = result[i];
                result[i] = buf;
            }
        }
    }
    return result;
}

int rowNum = ReadDataToInt("Введите количество строк ");
int colNum = ReadDataToInt("Введите количество столбцов ");

int[,] testArr = Gen2DArr(rowNum, colNum, 10, 99);
Console.WriteLine("Исходный массив: ");
Print2DArr(testArr);
Console.WriteLine();
Sort2DArr(testArr);
Console.WriteLine("Упорядоченный  по убыванию:");
Print2DArr(testArr);