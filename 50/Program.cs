//В двумерном массиве n×k заменить четные элементы на противоположные

int[,] matrix = new int[4, 4];

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

void ChangeArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] % 2 == 0)
            {
                matrix[i,j] = -1*matrix[i,j];
            } 
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
ChangeArray(matrix);