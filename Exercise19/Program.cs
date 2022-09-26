//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x = num /10000;
int y = (num / 1000) % 10;
int z = (num / 100) % 10;
int a = (num / 10) % 10;
int b = num % 10;

if(a == y & b == x) Console.WriteLine("Да это число палиндром!");
else Console.WriteLine("Нет это число не полиндром!");