//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

while(num > 0)
{
    result += num % 10;
    num = num / 10;
}
Console.WriteLine(result);