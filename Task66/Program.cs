/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int M = int.Parse(ReadLine());
Write("Введите N: ");   
int N = int.Parse(ReadLine());
WriteLine($"Сумма элементов = {GetSumBetweenElements(M, N)}");


int GetSumBetweenElements(int from, int to)
{
    if (from == to) return from;
    if (from == to - 1) return (from + to);
    return (from + to + GetSumBetweenElements(from + 1, to - 1));
}