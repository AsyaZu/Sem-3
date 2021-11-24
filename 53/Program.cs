// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[3, 3];

void FillArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

string ShowPosition (int[,] matrix)
{
    string res = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == num) 
            {
                res += $"[{i},{j}] ";
            }
        }
    }
    if (res == String.Empty)
    {
        res = "Число не найдено";
    }
    return res;
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine(ShowPosition(matrix));