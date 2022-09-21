//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число: ");
int num;
num = Convert.ToInt32(Console.ReadLine());
int x = num / 100;
int y = (num / 10) % 10;
int z = num % 10;
if(x < z || x > z) Console.WriteLine(y);