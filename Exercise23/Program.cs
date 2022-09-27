//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x = 1;
int y = 1;


while(x <= num)
{
    y = x * x * x;
    x++;
    Console.WriteLine(y);
}