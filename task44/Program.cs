﻿/*  Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8  */



int[] Fibonacci(int num)
{
int[] arrayFib = new int[num]; arrayFib[1] = 1;
for (int i = 2; i < num; i++)
{ arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
}
return arrayFib;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length) Console.Write($"{array[i]} ");
}
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int[] fibArray = Fibonacci(number);
PrintArray(fibArray);