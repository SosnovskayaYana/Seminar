﻿// программа, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Программа определит из двух целых чисел максимальное и минимальное. ");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 == number2)
    Console.WriteLine("Вы ввели одинаковые числа. Попробуйте сначала. ");

    else
    {
int max = 0;
int min = 0;
max = number1;

    if (max < number2)
    {
        max = number2;
        min = number1;
    }
    else
    {
        max = number1;
        min = number2;
    }

Console.Write($"max = {max}, min = {min} ");
    }