/*Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.*/

using System;
using static System.Console;

int exponentiate(int A) 
{
    int sum = 0;
    for (int i = 1; i <= A; i++) 
    {
        sum += i;
    }
    return sum;
}

Write("Введите число A: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());
WriteLine($"А в степени B = {exponentiate(A)}");