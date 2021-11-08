// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool F(bool X, bool Y)
{
    bool res = false;
    bool first = !(X||Y);
    bool second = !X && !Y;
    if (first == second)
    {
        res = true;
    }
    return res;
}
Console.WriteLine(F(false, true));

