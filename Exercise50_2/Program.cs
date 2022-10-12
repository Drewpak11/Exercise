// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



void FillArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i, j] = new Random().Next(0, 10);
            }   
        }
}

void PrintArr(int[,] array)
{
    Console.WriteLine("Массив");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} | ");
            }
            Console.WriteLine();
        }
}

void Search(int [,] array)
{
    Console.WriteLine();
    Console.WriteLine("Введите значение строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());
   
    if (i > array.GetLength(0) || j > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в массиве!");
    }
    else
    {
        Console.WriteLine($"Значение элемента {i} строки и {j} столбца = {array[i, j]}");
    }
    
}

int[,] array = new int [7, 7];
FillArr(array);
PrintArr(array);
Search(array);
