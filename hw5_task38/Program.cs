// Задача 38: 
// 1.Задайте массив вещественных чисел. 
// 2.Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

double FindDifferMaxMin (double [] array)
{
    int minPosition = 0;
    int maxPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minPosition]) minPosition = i;
        else if (array[i] > array[maxPosition]) maxPosition = i;  
        
    }
    return array[maxPosition] - array[minPosition];
}
    

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

double[] arr = CreateArrayRndDouble(5, 1, 99);
double differMaxMin = FindDifferMaxMin(arr);

PrintArray(arr);
Console.Write($" -> {Math.Round(differMaxMin, 1)}");
