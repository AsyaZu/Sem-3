// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int R(int X, int Y)
{
     int res = 0;
     if (X > 0 && Y > 0)
     {
         res = 1;
     }
     if (X < 0 && Y > 0)
     {
         res = 2;
     }
     if (X < 0 && Y < 0)
     {
         res = 3;
     }
     if (X > 0 && Y < 0)
     {
         res = 4;
     }

    return res;
 }
 Console.WriteLine(R(0, -6));