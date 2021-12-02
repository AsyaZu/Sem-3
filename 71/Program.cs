// Найти сумму цифр числа
int Sum(int number)
{
    if (number == 0) return 0;
    return number % 10 + Sum(number / 10);
}
Console.WriteLine(Sum(104));
