// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел: ");
int[] numbers = StringNum(Console.ReadLine());
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество значений больше 0 = {sum}");


int[] StringNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string help = string.Empty;

        while (input [i] != ' ')
        {
        if(i != input.Length - 1)
        {
            help += input [i].ToString();
            i++;
        }
        else
        {
            help += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(help);
        index++;
    }
    return numbers;
}