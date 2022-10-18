 // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++);
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("   Массив: ");
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

void Summ(int [,] matrix)
{
    
    int lineSum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < lineSum)
    {
        lineSum = sum;
        indexLine++;
    }
}
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой елементов под номером: {indexLine}");
Console.WriteLine();
Console.WriteLine($"Cумма елементов в строке = {lineSum}");
}

int[,] matrix = {{5, 7, 1, 6},
                 {2, 7, 3, 4},
                 {8, 1, 0, 9},
                 {3, 1, 7, 8},
                 {4, 5, 8, 6},
                 {5, 7, 2, 9}};
FillMatrix(matrix);
PrintMatrix(matrix);    
Summ(matrix);  