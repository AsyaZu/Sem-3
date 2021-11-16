// Найти расстояние между точками в пространстве 2D

//double FindH (int xa, int ya, int xb, int yb)
//{
//    int legX = xb -xa;
//    int legY = yb - ya;
//    double result = Math.Sqrt(Math.Pow(legX, 2) + Math.Pow(legY, 2));
//    return result;
//}
//Console.WriteLine(FindH(4, 5, 9, 2));

double FindH2 ((int x, int y) a, (int x, int y) b)
{
    int legX = b.x - a.x;
    int legY = b.y - a.y;
    double result = Math.Sqrt(Math.Pow(legX, 2) + Math.Pow(legY, 2));
    return result;
}


Console.WriteLine(FindH2((4, 5), (9, 2)));