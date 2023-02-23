// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в случайном порядке.

// запрос данных у пользователя
int ReadDate(string msg)
// выводим сообщение
{
  Console.Write(msg);
  // считываем число
  return(int.Parse(Console.ReadLine()??"0"));
}
int[] GenArr(int len,int min,int max)
{
  Random rnd=new Random();
  int[]arr=new int[len];
  for(int i=0;i<arr.Length;i++)
  {
    arr[i]=new Random().Next(min,max+1);
  }
  return arr;
}
void PrintArr(int[]arr)
{
  Console.Write("[");
  for(int i=0;i<arr.Length-1;i++)
  {
    Console.Write(arr[i]+",");
  }
  Console.WriteLine(arr[arr.Length-1]+"]");
}
PrintArr(GenArr(8,0,1));