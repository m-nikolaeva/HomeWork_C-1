// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер массива -> ");
int size1 = Convert.ToInt32(Console.ReadLine());


int[,] SpiralMatrix (int size)
{
int[,] spiral = new int[size, size];
int number = 1;
int i = 0;
int j = 0;

while (number <= size * size)
{
    spiral[i, j] = number;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    number++;
}
return spiral;
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

int[,] spiralMatrix = SpiralMatrix (size1); 
PrintMatrix(spiralMatrix);

