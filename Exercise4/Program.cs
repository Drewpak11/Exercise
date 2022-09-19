//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число a: ");
Console.WriteLine("Введите число b: ");
Console.WriteLine("Введите число с: ");
int num1;
int num2;
int num3;
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());
if(num1 < num2)
{
    Console.WriteLine($"Максимальное число: {num2}");
    
}
if(num2 < num3)
{
    Console.WriteLine($"Максимальное число: {num3}");
}
