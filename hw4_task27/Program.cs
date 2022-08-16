// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2.выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int NumSum(int number)
{
    number = Math.Abs(number);
    int sum = number % 10;
    for (int i = 0; number > 0; i++)
    {
        number = number / 10;
        sum += number % 10;
    }
    return sum;
}

int res = NumSum(num);
Console.WriteLine($"Сумма цифр в числе {num} -> {res}");