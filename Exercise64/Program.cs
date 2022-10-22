// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string NumbersRec(int n, int a)
{

    if (n >= a) return $"{n}" + NumbersRec(n - 1, a);
    else return String.Empty;

}
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.WriteLine(NumbersRec(n, a));