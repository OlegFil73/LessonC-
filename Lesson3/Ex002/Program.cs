// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

double distance(int ax, int ay, int bx, int by)
{
    int c = (ax - bx) * (ax - bx) + (ay - by) * (ay - by);
    double result = Math.Sqrt(c);
    return result;
}
double res = distance(7, -5, 1, -1);
Console.WriteLine($"{res} расстояние между A и B");