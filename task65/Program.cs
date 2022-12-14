﻿/* Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"  */

void Numbers(int num1, int num2) //   n 1  m 8
{
    if (num1 > num2)
    {
        Console.Write($"{num1}");
        Numbers(num1 - 1, num2);
    }

    if (num1 < num2)
    {
        Console.Write($"{num1}");
        Numbers(num1 + 1, num2);
    }

    if (num1 == num2) Console.Write($"{num1}");
}

Console.Write("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());


Numbers(m, n);


//m else Console.Write("Некорректный ввод. ");

