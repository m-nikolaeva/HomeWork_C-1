// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


Console.Write("Введите номер строки -> ");
int x0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца -> ");
int y0 = Convert.ToInt32(Console.ReadLine());


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

void FindElement(int[,] matrix, int x, int y)
{
    if (x - 1 < 0 || y - 1 < 0) Console.WriteLine("Вы ввели некорректные значения. Попробуйте снова.");
    else if (x - 1 < matrix.GetLength(0) && y - 1 < matrix.GetLength(1)) Console.WriteLine($"{x}, {y} -> {matrix[x - 1, y - 1]}");
    else Console.WriteLine($"{x}, {y} -> такого элемента в массиве нет");
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

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
FindElement(array2D, x0, y0);