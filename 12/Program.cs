//Удалить вторую цифру трёхзначного числа

int Number (int n)
{
    int first = (n - (n % 100)) / 10;
    int second = n % 10;
    int res =  first + second;
    return res;
}
Console.WriteLine(Number(791));