// Найти сумму чисел от 1 до А
//double Sum(int A)
//{
//    double sum = 0;
//    for (int n = 1; n <= A; n++)
//    {
//        sum = n + sum;
//    }
//    return sum;
//}

//int n = 1_000_000_000;
//DateTime dt = DateTime.Now;
//Console.WriteLine(Sum(n));
//Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

int Sum2(int a)
{
    return (a * (a + 1)) / 2;
}
int n = 1_000_000_000;
DateTime dt = DateTime.Now;
Console.WriteLine(Sum2(n));
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);