// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] CreateUniqueArrayInt(int x, int y, int z, int min, int max)
{
    int[] array = new int[x * y * z];
    int number = 0;
    Random rnd = new Random();
    for (int a = 0; a < x * y * z; a++)
    {
        array[a] = rnd.Next(min, max + 1);
        number = array[a];
        if (a >= 1)
        {
            for (int b = 0; b < a; b++)
            {
                while (array[a] == array[b])
                {
                    array[a] = rnd.Next(min, max + 1);
                    b = 0;
                    number = array[a];
                }
                number = array[a];
            }
        }
    }
    int count = 0;
    int[,,] martix3D = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                martix3D[i, j, k] = array[count];
                count++;
            }
        }
    }
    return martix3D;
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

int[,,] createUniqueArrayInt = CreateUniqueArrayInt(2, 2, 2, 10, 99);
Print3DMatrix(createUniqueArrayInt);

// int[,,] createUniqueArrayInt = CreateUniqueArrayInt(2, 2, 2, 10, 17); //проверка, что все числа уникальны.
// Print3DMatrix(createUniqueArrayInt);


// Console.Write("Введите число X: ");                //для ввода данных пользователем
// int x0 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Y: ");
// int y0 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Z: ");
// int z0 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное число диапозона: ");
// int min0 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число диапозона: ");
// int max0 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,,] createUniqueArrayInt = CreateUniqueArrayInt(x0, y0, z0, min0, max0); 
// Print3DMatrix(createUniqueArrayInt);


