//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Number (int n)
{
    int second = (n % 10);
    int first = (n - second) / 10;
    if (first > second)
    {
        return first;
    }
    else
    {
        return second;
    }
    
}

int n = new Random().Next(10, 100);
Console.WriteLine(n);
Console.WriteLine(Number(n));
