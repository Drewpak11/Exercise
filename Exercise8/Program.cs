//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int n;
n = Convert.ToInt32(Console.ReadLine());
int result = n / 2;
while(result > 0)
{
    Console.WriteLine(result * 2);
    result -= 1;
}