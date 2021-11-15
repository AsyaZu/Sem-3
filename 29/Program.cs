// Написать программу вычисления произведения чисел от 1 до N

//double Multiplication (int A)
//{
//    double mult = 0;
//    for (int n = 1; n <= A; n++)
//    {
//        sum = n + sum;
//    }
//    return sum;
//}

int Multiplication (int N)
{
    if (N == 1) return 1;
    return N * Multiplication(N - 1); 
}

DateTime dt = DateTime.Now;
Console.WriteLine(Multiplication(1));
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);