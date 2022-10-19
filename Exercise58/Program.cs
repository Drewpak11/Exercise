// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Матрица 1: ");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}]");
        }
        Console.WriteLine();
    }
}
void FillMatrix1(int[,] matrix1)
{
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintMatrix1(int[,] matrix1)
{
    Console.WriteLine("Матрица 2: ");
    Console.WriteLine();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"[{matrix1[i, j]}]");
        }
        Console.WriteLine();
    }
}

void Summ(int[,] matrix, int [,] matrix1)
{
    int sum = 0;
    Console.WriteLine();
    Console.WriteLine("Произведение двух матриц: ");
    Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = matrix[i, j] * matrix1[i, j];
            Console.Write($"[{sum}]");
        }
        Console.WriteLine();
    }
}


int[,] matrix = new int[4, 2];
int[,] matrix1 = new int[4, 2];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FillMatrix1(matrix1);
PrintMatrix1(matrix1);
Summ(matrix, matrix1);