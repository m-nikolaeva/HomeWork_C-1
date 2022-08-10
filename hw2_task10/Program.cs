// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number / 10; //получили двузначное
int result = a % 10; //получили последнюю цифру
if (number > 99 && number < 1000 || number < -99 && number > -1000) Console.WriteLine($"{number} -> {result}");
else Console.WriteLine("Число не трехзначное. Попробуйте снова.");
