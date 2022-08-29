// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[,] CreateMatrixRndDouble(int row, int col, int min, int max)   //метод создания рандомного двумерного массива
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 0);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)   //метод вывода в консоль двумерного массива
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

double[] GetArithmeticAverageCol(double[,] matrix)//метод поиска ср. арифм. по столбцам, с сохранением рез-та в одномер. массив
{
    int col = matrix.GetLength(1);
    int row = matrix.GetLength(0);
    double[] array = new double[col];
    double result = 0;
    for (int j = 0; j < col; j++)
    {
        double sum = 0;
        for (int i = 0; i < row; i++)
        {
            sum = sum + matrix[i, j];
            result = Math.Round(sum / row, 1);
        }
        array[j] = result;
    }
    return array;
}

void PrintArray(double[] array)  //метод вывода в консоль одномерного массива 
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write(".");
}


double[,] array2D = CreateMatrixRndDouble(3, 4, 1, 10);
PrintMatrixDouble(array2D);
double[] getArithmeticAverageCol = GetArithmeticAverageCol(array2D);
PrintArray(getArithmeticAverageCol);



