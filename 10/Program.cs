//Показать вторую цифру трёхзначного числа

int Number (int n)
{
    int res = ((n % 100) - (n % 10)) / 10;
    return res;
}
Console.WriteLine(Number(816));