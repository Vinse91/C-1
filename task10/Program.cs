﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5- > да
// 8, 9 -> нет

Console.Write("ВВедите число a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine());

if (a == b * b || b == a * a)

{
    Console.Write("Да, является квадратом");

}
else
{
    Console.Write("Нет, не является квадратом");

}