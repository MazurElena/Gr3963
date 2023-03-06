// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//метод генерации массива
int[,] Gen2DArr(int Row,int Coloumn,int min,int max)
{
    
    int[,] arr=new int[Row,Coloumn];
    for(int i=0;i<Row;i++)
    {
        for(int j=0;j<Coloumn;j++)
        {
            arr[i,j]=new Random().Next(min,max+1);
        }
    }
    return arr;
} 
// Метод, выводящий на печать двухмерный массив
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            Console.ForegroundColor=col[new Random().Next(0,16)];
            Console.Write(arr[i,j]+"\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    } 
}
//Метод, выводящий на печать одномерный массив
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод поиска среднеарифметического по столбцам
double[]ColMean2DArr(int[,]arr)
{
  double[] resArr=new double[arr.GetLength(1)];
  for(int j=0;j<arr.GetLength(1);j++)
  {
    for(int i=0;i<arr.GetLength(0);i++)
    {
      resArr[j]+=arr[i,j];
    }
    resArr[j]=Math.Round(resArr[j]/arr.GetLength(0),4);
  }
  return resArr;
}

int row =ReadData("Введите количество строк ");
int column=ReadData("Введите количество столбцов ");

int[,] arr2D= Gen2DArr(row,column,10,99);
Print2DArr(arr2D);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
Print1DArr(ColMean2DArr(arr2D));


