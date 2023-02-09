/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int N = int.Parse(ReadLine());
Console.Write("1");
for (int i = 2; i <= N; i++) 
{
    Console.Write($", {i*i*i}");
}