﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("ВВедите число N = "); 
int N = int.Parse(Console.ReadLine()); 

int a = 0;
double b = 0;
a = N%10;
b = N/10;

Console.WriteLine("Деление с остатком" + " " + a + " ");
Console.Write("Целочисленное деление" + " " + b + " ");