// Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m, n];

void FillArray (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().NextDouble();
        }
    }
}

void PrintArray (double[,] matrix)
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
