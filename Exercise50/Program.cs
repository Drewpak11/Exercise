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
        for (int j = 0; j < array.GetLength(1); j++) ;
    }
}

void Numbers(int[,] array)
{
    int num = 0;
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 9 | num < 1) Console.WriteLine("Такого числа нет в массиве!");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num) Console.WriteLine("Такое число есть в массиве!");
        }
    }
}

int[,] array = {{1, 5, 9},
                {7, 3, 6},
                {4, 8, 2}};
FillArr(array);
Console.WriteLine("Введите число: ");
Numbers(array);