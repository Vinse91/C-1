﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 --> 46
// 782 --> 72
// 918 --> 98

Console.Clear();
int N = new Random().Next(110, 1000);
Console.WriteLine("Компьютер выбрал число: " + N);

//int a1 = N/10;
//int a11 = a1/10;
int a11 = N/100;
int a3 = N%10;
int a2 = a1%10;
N1 = 10*a11 + a3;

//Console.WriteLine("Вспомогательный расчет: " + a1);
//Console.WriteLine("Второе число: " + a2);
Console.WriteLine("Третье число: " + a3);
Console.Writeline("В итоге двузначное число: " + N1);