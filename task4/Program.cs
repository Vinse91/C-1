﻿// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


Console.Write("ВВедите число N = "); // вводим просьбу пользователя ввести данные (пользователь видит то, что написано в скобках в кавычках)
int N = int.Parse(Console.ReadLine(); // ввод целого числа от пользователя - читает компьютер, а вводит человек

int a = -N;

while (a < N+1)

{
    Console.Write(" " + a + " ");
    a = a + 1;

}