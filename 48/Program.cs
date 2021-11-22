// 48. Показать двумерный массив размером m×n заполненный целыми числами
Console.WriteLine("m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [m, n];

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
            Console.Write(matrix[i,j]);
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);