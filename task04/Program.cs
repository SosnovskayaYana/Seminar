﻿// программа, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2 3 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа определит максимальное число ");

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = 0;
max = number1;

if (max < number2)
    {
        max = number2;
    }
    else
    {
        max = number1;
    }

if (max < number3)
    {
        max = number3;
    }
    
    Console.Write($"max = {max}");
