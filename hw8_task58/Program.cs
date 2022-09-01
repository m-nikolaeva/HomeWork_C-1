// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите число строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк второй матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());

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

int[,] ProductOfMatrix(int[,] matrix1, int[,] matrix2, int m0, int n0, int l0) 
{
    int[,] matrix3 = new int[m0, l0];
    for (int i = 0; i < m0; i++)
    {
        for (int j = 0; j < l0; j++)
        {
            for (int t = 0; t < n0; t++)
            {
                matrix3[i, j] += matrix1[i,t] * matrix2[t, j];
            }
        }
    }
    return matrix3;
}

if (n != k) Console.WriteLine("Произведение матриц возможно при условии: число столбцов первой матрицы = числу строк второй матрицы.");
else if (n == k)
{
    int[,] mtx1 = CreateMatrixRndInt(m, n, 1, 3);
    Console.WriteLine("Первая матрица:");
    PrintMatrix(mtx1);

    int[,] mtx2 = CreateMatrixRndInt(n, l, 1, 3);
    Console.WriteLine("Вторая матрица:");
    PrintMatrix(mtx2);
    Console.WriteLine();

    int[,] productOfMatrix = ProductOfMatrix(mtx1, mtx2, m, n, l);
    Console.WriteLine("Произведение двух матриц:");
    PrintMatrix(productOfMatrix);
    Console.WriteLine();
}