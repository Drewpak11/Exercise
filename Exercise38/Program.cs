// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArr(double[] array)
{
    for(int i = 0; i < array.Length; i++);
}

void PrintArr(double[] array)
{   
    Console.Write("Массив: ");
    for(int i = 0; i < array.Length; i++) Console.Write($"[{array[i]}], ");
}

void DiffArr(double[] array)
{
    double min = 0;
    double max = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
    if (array[j] <= min)
        {
            min = array[j];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Максимальное значение: {max}");
    Console.WriteLine($"Минимальное значение: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}

double[] array = {22.2, 77.3, -5.5, 9.5, 44.6, -23.9, 11.1, 98.6};
FillArr(array);
PrintArr(array);
DiffArr(array);