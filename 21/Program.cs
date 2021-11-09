// Программа проверяет пятизначное число на палиндромом
bool Palindrome (int n)
{
    bool res = false;
    int fifth = n % 10;
    int first = (n - (n % 10000)) / 10000;
    int second = (n % 10000 - n % 1000) / 1000;
    int fourth = (n % 100 - first) / 10;
    if (first == fifth && second == fourth)
    {
        res = true;
    }
    return res;
}
Console.WriteLine(Palindrome(71431));
