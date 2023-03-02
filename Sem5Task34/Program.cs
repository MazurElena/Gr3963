// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// int[] Gen1DArr(int len, int min, int max)
// {
//     // Корректировка входных данных
//     if (min > max)
//     {
//         int buf = min;
//         min = max;
//         max = buf;
//     }

//     Random rnd = new Random();
//     int[] arr = new int[len];

//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]},\t");
//     }
//     Console.WriteLine($"{arr[arr.Length - 1]}]");
// }
// //Метод для вывода данных
// void WriteMess(string mess)
// {
//     Console.WriteLine(mess);
// }
// // Метод подсчета
// int NumElemInRange(int[] arr)
// {
//     int res = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) res++;
//     }

//     return res;
// }



// int[] mass = Gen1DArr(11, 100, 1000);
// Print1DArr(mass);


// WriteMess($"Четных чисел в массиве: {NumElemInRange(mass)}");



// Вариант преподавателя

// Метод генерирующий массив
int[] Gen1DArr(int len, int min, int max)
{
    int[] arr = new int[len];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }

    return arr;
}
// Метод, выводящий на печать данные пользователя
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Метод выводящий на печать массив
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
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
// Метод сортировки пузырьком
void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    for (int j = 0; j < arr.Length - i - 1; j++)
     {
        if (arr[j] > arr[j + 1])
        {
            int buf=arr[j];
            arr[j]=arr[j+1];
            arr[j+1]=buf;
        }
     }           
}
// Сортировка методом подсчета
void CountingSort(int[] arr)
{
    int max=arr.Max();
    int min=arr.Min();

    int[] count=new int[max-min+1];
    int z =0;
    for(int i=0;i<count.Length;i++)
    {
        count[i]=0;
    }
    for (int i=0;i< arr.Length;i++)
    {
        count[arr[i]-min]++;
    }
    for(int i =min;i<=max;i++)
    {
        while(count[i-min]-->0)
        {
            arr[z]=1;
            z++;
        }
    }

}

int[] mass = Gen1DArr(115, 100, 1000);
// BubbleSort(mass);
Print1DArr(mass);
int result=NumElemInRange(mass);
PrintData(result.ToString());

CountingSort(mass);