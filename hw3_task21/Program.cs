// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x координату первой точки: ");
int xa1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату первой точки: ");
int ya1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z координату первой точки: ");
int za1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x координату второй точки: ");
int xb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату второй точки: ");
int yb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z координату второй точки: ");
int zb2 = Convert.ToInt32(Console.ReadLine());


double GetDist(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
}

double result = GetDist(xa1, ya1, za1, xb2, yb2, zb2);
Console.WriteLine($"A ({xa1},{ya1},{za1}); B ({xb2},{yb2},{zb2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");