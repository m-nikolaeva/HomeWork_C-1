// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[] SumElemRow(int[,] matrix)
{
    int col = matrix.GetLength(1);
    int row = matrix.GetLength(0);
    int[] array = new int[row];
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < col; j++)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

int MinPosition(int[] array)
{
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<array[minIndex]) minIndex=i;
    }
    return minIndex;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] mtx = CreateMatrixRndInt(m, n, 1, 9);
PrintMatrix(mtx);
Console.WriteLine();
int[] sumElemRow = SumElemRow(mtx);
int minPosition = MinPosition (sumElemRow);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: № {minPosition+1}");