﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.Write("введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 2;
while (num2 <= num)
{
    Console.Write(num2 + " ");
    num2 = num2 + 2;
}






  