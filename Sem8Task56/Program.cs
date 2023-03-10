// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
// Метод, выводящий на печать данные пользователя
void PrintData(string res)
{
    Console.WriteLine(res);
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
int MinRowCount(int[,]arr)
{
  int index=-1;int min=int.MaxValue;
  for(int i=0;i<arr.GetLength(0);i++)
  {
    int sum=0;
    for(int j=0;j<arr.GetLength(1);j++)
    {
      sum=sum+arr[i,j];
    }
    if(sum<min)
    {
      min=sum;
      index=i;
    }
  }
  return index;
}
int[,] testArr = Gen2DArr(10, 8, 10, 99);
Console.WriteLine("Исходный массив: ");
Print2DArr(testArr);
Console.WriteLine();
int result=MinRowCount(testArr);
PrintData("Номер строки с наименьшей суммой элементов: "+result.ToString());
