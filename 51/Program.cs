// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int m = 3;
int n = 4;
int[,] matrix = new int[m, n];

void PrintArray(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = m + n; 
            Console.Write(matrix[m, n]);
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);