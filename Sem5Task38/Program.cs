// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
void PrintData(string text, double print)
{
    Console.WriteLine($"{text}:{print}");
}
double[] GenArry(int min, int max, int indexcount)
{
    // Метод генерирования
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    double[] binarray = new double[indexcount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < indexcount; i++)
    {
      binarray[i] = Math.Round(-min + numSintezator.NextDouble()*(min+max),2);
    }
    return binarray;
}
// Вывод массива на консоль
void Print1DArr(double[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
// Поиск пар чисел
(double min, double max) FindMinMaxArry(double[] array)
{
    double arrlen = array.Length;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < arrlen; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else
        {
            max = array[i];
        }

    }

    return (min, max);
}
//Сортируем
void SortInsertArry(double[] array)
{ 

    for (int i = 1; i < array.Length; i++)
    {
        double k = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > k)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = k;
    }

}
//Вывод исходного массива
double[] array = GenArry(1, 100, 15);
Console.Write("Исходный массив:");
Print1DArr(array);
Console.Write("Сортировка методом вставки:");
SortInsertArry(array);
Print1DArr(array);

(double min, double max) result = FindMinMaxArry(array);
PrintData("Минимальное значение", result.min);
PrintData("Максимальное значение", result.max);
PrintData("Разница max-min", result.max - result.min);




