// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b02 - b01) / (k01 - k02), при к1==к2 - прямые параллельны, либо совпадают.
// k01 * (b02 - b01) / (k01 - k02) + b01 == k02 * (b02 - b01) / (k01 - k02) + b02);



Console.Write("Введите число b1 -> ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1 -> ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2 -> ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2 -> ");
double k2 = Convert.ToDouble(Console.ReadLine());

void IntersectionPoint(double b01, double k01, double b02, double k02)
{
    if (k01 == k02) Console.WriteLine("Прямые параллельны, либо совпадают. Введите другие числа.");
    else if (k01 * (b02 - b01) / (k01 - k02) + b01 == k02 * (b02 - b01) / (k01 - k02) + b02) 
    Console.Write($" -> ({(b02 - b01) / (k01 - k02)};{k01 * (b02 - b01) / (k01 - k02) + b01})");
}

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ");
IntersectionPoint(b1, k1, b2, k2);