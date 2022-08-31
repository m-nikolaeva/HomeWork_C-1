// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] Create3DMatrixRndInt(int x, int y, int z, int min, int max)
{
    int[,,] matrix3d = new int[x, y, z];
    Random rnd = new Random();

    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(2); k++)
            {
                matrix3d[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix3d;
}

int[] CreateArrayInt(int[,,] matrix3D, int x, int y, int z)
{
    int[] array = new int[x * y * z];
    int n = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[n++] = matrix3D[i, j, k];
            }
        }
    }
    return array;
}






        void Print3DMatrix(int[,,] matrix3d)
        {
            for (int i = 0; i < matrix3d.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3d.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3d.GetLength(2); k++)
                    {
                        Console.Write($"{matrix3d[i, j, k]}({i},{j},{k}) ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write(array[i]);
            }
            Console.Write("]");
        }


        int[,,] mtx3D = Create3DMatrixRndInt(2, 2, 2, 10, 99);
        Print3DMatrix(mtx3D);
        int[] createArrayInt = CreateArrayInt(mtx3D, 2, 2, 2);
        PrintArray(createArrayInt);


