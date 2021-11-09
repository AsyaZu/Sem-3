// Найти расстояние между точками в пространстве 2D

double FindH (int xa, int ya, int xb, int yb)
{
    int legX = xb -xa;
    int legY = yb - ya;
    double result = Math.Sqrt(Math.Pow(legX, 2) + Math.Pow(legY, 2));
    return result;
}
Console.WriteLine(FindH(4, 5, 9, 2));