﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 --> нет
// 46 --> нет
// 161 --> да

Console.Write ("Enter the first number: ");
int N1 = int.Parse(Console.ReadLine());

int ost;

if (N1%7 == 0)
{
    Console.WriteLine ("Число N1 кратно числу 7");

}
else
{

    Console.WriteLine ("Число N1 не кратно числу 7");

}



if (N1%23 == 0)
{
    Console.Write ("Число N1 кратно числу 23");

}
else
{

    Console.Write ("Число N1 не кратно числу 23");

}