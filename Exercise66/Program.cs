// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int NumbersSum(int m, int n)
{
    if (m >= n) return n;
    return n + NumbersSum(m, n - 1);
}
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от M до N: {NumbersSum(m, n)}");