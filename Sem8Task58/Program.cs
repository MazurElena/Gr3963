// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// метод умножения двух матриц
int[,] MultiArrys(int[,] arry1, int[,] arry2)
{
    if ((arry1.GetLength(0) != arry2.GetLength(0)) || (arry1.GetLength(1) != arry2.GetLength(1)))
    {
        throw new Exception("Для матриц с разным размером сложение не возможно!");
    }

    int[,] arry3 = new int[arry1.GetLength(0), arry2.GetLength(1)];

    for (var i = 0; i < arry1.GetLength(0); i++)
    {
        for (var j = 0; j < arry2.GetLength(0); j++)
        {
            arry3[i, j] = 0;

            for (var k = 0; k < arry1.GetLength(1); k++)
            {
                arry3[i, j] += arry1[i, k] * arry2[k, j];
            }
        }
    }
    return arry3;
}

int[,] testArr = Gen2DArr(4, 4, 1, 10);
int[,] testArr1 = Gen2DArr(4, 4, 1, 10);
Console.WriteLine("Исходные массивы: ");
Print2DArr(testArr);
Console.WriteLine();
Print2DArr(testArr1);
Console.WriteLine();
int[,] multiMatrix = MultiArrys(testArr, testArr1);
Console.WriteLine("Результат:");
Print2DArr(multiMatrix);

