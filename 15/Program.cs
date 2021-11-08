bool Multiplicity (int n)
{
    return n % 7 == 0 && n % 23 == 0;
}
Console.WriteLine(Multiplicity(161));
