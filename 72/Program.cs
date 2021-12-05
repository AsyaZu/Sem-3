// Написать программу возведения числа А в целую стень B

int Exponentiation(int A, int B)
{
    if (B == 0) return 1;
    return A * Exponentiation(A, B - 1);
}

Console.WriteLine(Exponentiation(11, 2));