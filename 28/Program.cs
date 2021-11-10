// Подсчитать сумму цифр в числе

int Sum (int number)
{
    int sum = 0;
    while (number >= 1)
    {
        sum = sum + number % 10;
        number = (number - number % 10) / 10;
    }
    return sum;
}
Console.WriteLine(Sum(0));