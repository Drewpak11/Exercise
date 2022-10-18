// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArr(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++);
    }
}

void PrintArr(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]");
        }
        Console.WriteLine();
    }
}

void Result(int[,] array)
{
    int help = 0;
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] < array[i, z + 1]) 
            {
                help = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = help;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями:");
}


int[,] array = {{5, 8, 1, 6},
                 {2, 7, 3, 4},
                 {11, 5, 17, 9},
                 {3, 10, 13, 8}};
FillArr(array);
Console.WriteLine("Массив:");
PrintArr(array);    
Result(array);       
PrintArr(array);   