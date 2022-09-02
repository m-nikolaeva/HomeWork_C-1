// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29 <> ошибка, при нахождении результата перепутаны m и n, при m = 2, n = 3 -> A(m,n) = 9 

//max: m = 4, n = 0; возможно максимальным поставить m = 4, n = 1 -> A(m,n) = 65533, только вывод результата подвисает

Console.Clear();
Console.Write("Введите первое число из диапозона от 0 до 4: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число из диапозона от 0 до 5: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (a >= 4 && b > 0 || a >= 5 && b >= 0 || b > 5) Console.WriteLine("Некорректный ввод. Невозможно произвести подсчет.");
else
{
    Console.WriteLine($"При m ={a}, n = {b} -> A(m,n) = {Akkerman(a, b)}");

    int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return Akkerman(m - 1, 1);
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.WriteLine();
