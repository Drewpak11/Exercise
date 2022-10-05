// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArr(int[] array)
{
    for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 100);
}

void PrintArr(int[] array)
{
    Console.Write("Массив: ");
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");
}

void SumArr(int[] array)
{
    int sum = 0;
    for(int j = 1; j < array.Length; j += 2) sum = sum + array[j];
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
        
    
}

int [] array = new int [10];
FillArr(array);
PrintArr(array);
SumArr(array);