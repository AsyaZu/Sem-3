// Найти расстояние между точками в пространстве 3D

double FindH (int xa, int ya, int xb, int yb, int zx, int zy)
{
    int X = xb -xa;
    int Y = yb - ya;
    int Z = zx - zy;
    double result = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) +  Math.Pow(Z, 2));
    return result;
}
Console.WriteLine(FindH(4, 5, 9, 2, 7, 12));
