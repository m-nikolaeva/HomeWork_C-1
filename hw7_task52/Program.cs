// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

// void GetArithmeticAverageCol(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             sum += matrix[i, j];
//         }
//         sum = Math.Round(sum / matrix.GetLength(1), 1);
//     }
// }


void GetArithmeticAverageCol(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            array[i] = Math.Round(sum / matrix.GetLength(1), 1);
        }
    }
}
// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
//     }
//     return array;
// }

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


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
// double getArithmeticAverageCol = GetArithmeticAverageCol(array2D);
GetArithmeticAverageCol(array2D);
PrintArray(array);