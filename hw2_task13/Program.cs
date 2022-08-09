// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int remainder = a % 10;

while (a > 999 || a<-999)
{
    a = a / 10;
    remainder = a % 10;
}
if (a >= 100 && a <= 999 || a<=-100 && a>=-999) Console.WriteLine($"Третья цифра числа -> {remainder}");
else if (a < 99 || a>-99) Console.WriteLine("Третьей цифры нет");



