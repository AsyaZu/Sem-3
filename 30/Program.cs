// Показать кубы чисел, заканчивающихся на четную цифру
void Cube (int N)
{
    for (int n = 1; n <= N; n++)
    {
        int res = n * n * n;
        if (res % 10 % 2 == 0)
        {
            Console.WriteLine($"{n}^3 = {res}");
        }
    }
}
Cube(16);