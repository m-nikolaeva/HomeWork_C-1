// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите целое положительное чиcло M -> ");
int m0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное чиcло N -> ");
int n0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int result = SumNaturElem(m0, n0);
Console.WriteLine($"Сумма натуральных чисел в промежутке от M = {m0} до N = {n0} равна {result}");
Console.WriteLine();

int SumNaturElem(int m, int n)
{
    if (m == n) return m;
    if (m < n) return m + SumNaturElem(m + 1, n);
    return m + SumNaturElem(m - 1, n);
}