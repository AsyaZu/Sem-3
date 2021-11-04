// Показать четные числа от 1 до N

void ShowNumbers(int a, int b)
{
    int NextNumber = a;
    while (NextNumber <= b)
    {
        if (NextNumber % 2 == 0)
        {
            Console.WriteLine(NextNumber);
        }
        NextNumber++;
    }
}
ShowNumbers(1, 30);
