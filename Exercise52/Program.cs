// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++);
    }
}

void PrintArr(double[,] array)
{
    Console.WriteLine("  Массив ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} |");
        }
        Console.WriteLine();
    }

}

void Average(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++);
    }
    Console.WriteLine();
    Console.WriteLine($"Среднее арифметическое столбцa 0 = {Math.Round((array[0, 0] + array[1, 0] + array[2, 0]) / 3, 2)}");
    Console.WriteLine($"Среднее арифметическое столбцa 1 = {Math.Round((array[0, 1] + array[1, 1] + array[2, 1]) / 3, 2)}");
    Console.WriteLine($"Среднее арифметическое столбцa 2 = {Math.Round((array[0, 2] + array[1, 2] + array[2, 2]) / 3, 2)}");
}


double[,] array = {{1, 5, 9},
                   {7, 3, 6},
                   {4, 8, 2}};
FillArr(array);
PrintArr(array);
Average(array);