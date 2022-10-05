// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArr(int[] array)
{
    Console.Write("Массив: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    
    Console.WriteLine();
}

void Sum(int[] array)
{
    int count = 0;

    for (int j = 0; j < array.Length; j++)
    if (array[j] % 2 == 0)
    count++;

    Console.WriteLine($"Четных чисел в массиве: {count}");
}

int[] array = new int[10];
FillArr(array);
PrintArr(array);
Sum(array);