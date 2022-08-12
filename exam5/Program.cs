// Задача 1.
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка 
// и показывает диапазон возможных координат точек в этой четверти (x и y).

// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

void quatr(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("Error!");

    if (x > 0 && y > 0)
        Console.WriteLine("First quatr");

    if (x < 0 && y > 0)
        Console.WriteLine("Second quatr");

    if (x < 0 && y < 0)
        Console.WriteLine("Third quatr");

    if (x > 0 && y < 0)
        Console.WriteLine("Fourth quatr");
    return;
}

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

quatr(x, y);



double distance(int x_a, int y_a, int x_b, int y_b)
{
    double d = Math.Sqrt(Math.Pow(x_b - x_a, 2) + Math.Pow(y_b - y_a, 2));
    return d;
}
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

double result = distance(x1, y1, x2, y2);
Console.WriteLine(result);