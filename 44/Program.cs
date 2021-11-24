// Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 и k2 заданы

string PointFinder(int k1, int b1, int k2, int b2)
{
    int x = 0;
    int y = 0;
    string res = string.Empty;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    res = $"({x}, {y}) ";
    return res;
}
Console.WriteLine(PointFinder(5, 10, 6, 8));
