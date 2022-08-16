// Задача 25: Напишите цикл, который 
// 1.принимает на вход два числа (A и B) и 
// 2.возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b <= 0)
{
    Console.Write("Вы ввели недопустимое значение");
    return;
}

int RaiseDegree(int a1, int b1)  //возведение в степень
{
    int result = 1;
    for (int i = 0; i < b1; i++)
    {
        result *= a1;
    }
    return result;
}

int res = RaiseDegree(a, b);
Console.WriteLine($"{a}, {b} -> {res}");