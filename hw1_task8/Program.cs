﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n = 2;
int b;

if (n <= a)
{
    b = n % 2;
}
for (b = 0; n <= a; n += 2)
{
    Console.Write($"{n}, ");
}
