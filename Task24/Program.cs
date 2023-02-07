using System;
using static System.Console;

int getSumOfNumbers(int num) 
{
    int sum = 0;
    for (int i = 1; i <= num; i++) 
    {
        sum += i;
    }
    return sum;
}

Write("Введите число N: ");
int N = int.Parse(ReadLine());
WriteLine($"Сумма чисел = {getSumOfNumbers(N)}");
