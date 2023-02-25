// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// Ввести с клавиатуры длину массива и диапазон значений элементов.

// запрос данных у пользователя
int ReadDate(string msg)
// выводим сообщение
{
  Console.Write(msg);
  // считываем число
  return(int.Parse(Console.ReadLine()??"0"));
}
int[] GenArr(int num, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int lenArray = ReadDate("Введите длинну массива: ");
PrintArr(GenArr(25,5,11));
