// Написать программу вычисления произведения чисел от 1 до N

int Multiplication (int N)
{
    int mult = 1;
    for (int n = 1; n <= N; n++)
    {
        mult = mult * n;
    }
    return mult;
}
Console.WriteLine(Multiplication(5));
