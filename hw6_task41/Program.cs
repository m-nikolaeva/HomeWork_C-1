// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4


Console.Write("Задайте количество вводимых чисел -> ");
int m1 = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayInt(int m)
{
    int[] array = new int[m];
    
    for (int i = 0; i < m; i++)
{
    Console.Write("Введите число -> ");
    int n = Convert.ToInt32(Console.ReadLine());
    array[i] = n;
}
    return array;
}

int GetCountGreaterZero (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count ++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
}

int[] arr = CreateArrayInt(m1);
int getCountGreaterZero = GetCountGreaterZero(arr);
PrintArray(arr);
Console.Write($" -> {getCountGreaterZero}");