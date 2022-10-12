// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



void FillArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }

    }
}


void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] / 10} |");
        }
        Console.WriteLine();

    }
}

double[,] array = new double[3, 3];
FillArr(array);
PrintArr(array);
