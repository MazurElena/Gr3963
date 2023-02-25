﻿// Задача №31 Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Блок корректировки входных данных
int[] Gen1DArr(int len, int minValue, int maxValue)
{
  if(minValue>maxValue)
{
  int buf=minValue;
  minValue=maxValue;
  maxValue=buf;
}
  Random rnd = new Random();
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = rnd.Next(minValue, maxValue+1);
    }
    return arr;
}
// Печатаем одномерный массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
void PrintData(string res, int value)
{
  Console.WriteLine(res+value);
}
(int posit, int negot)NegPosSum(int[]arr)
{
  int positSum=0;
  int negotSum=0;
  for(int i=0;i<arr.Length;i++)
  {
    if(arr[i]>0)
    {
      positSum+=arr[i];
    }
    else
    {
      negotSum+=arr[i];
    }
  }
  return(positSum, negotSum);
}
int[]testArr=Gen1DArr(12,-9,9);
Print1DArr(testArr);
(int posit,int negot)results=NegPosSum(testArr);
PrintData("Сумма положительных чисел в массиве: ", results.posit);
PrintData("Сумма отрицательных чисел в массиве: ", results.negot);