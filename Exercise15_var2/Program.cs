//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру: ");
int num;
num = Convert.ToInt32(Console.ReadLine());

if(num == 6 || num == 7) 
{
    Console.WriteLine("Выходной");
    
}
else if(num < 1 || num > 7) Console.WriteLine("Нет такого дня недели!");
else Console.WriteLine("Будний");