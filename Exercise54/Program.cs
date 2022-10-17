// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++);
    }
}

void PrintMatrix(int[,] matrix)
{
    // Console.WriteLine("  Массив ");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} |");
        }
        Console.WriteLine();
    }
}

void Result(int[,] matrix)
{
    int help = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < matrix.GetLength(1) - 1; z++)
        {
            if (matrix[i, z] < matrix[i, z + 1]) 
            {
                help = matrix[i, z];
                matrix[i, z] = matrix[i, z + 1];
                matrix[i, z + 1] = help;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями:");
}


int[,] matrix = {{5, 8, 1, 6},
                 {2, 7, 3, 4},
                 {11, 5, 17, 9},
                 {3, 10, 13, 8}};
FillMatrix(matrix);
Console.WriteLine("Массив:");
PrintMatrix(matrix);    
Result(matrix);       
PrintMatrix(matrix);   