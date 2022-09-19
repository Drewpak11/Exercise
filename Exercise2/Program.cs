//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число a: ");
Console.WriteLine("Введите число b: ");

int num1;
int num2;

num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2)
{
    Console.WriteLine($"Максимальное число: {num2} Минимальное число {num1}");
    
}
if(num1 > num2)
{
    Console.WriteLine($" Максимальное число {num1} Минимальное число: {num2}");
}