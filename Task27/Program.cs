/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

using System;
using static System.Console;

int getSumOfDigits(int num) 
{
    int sum = 0;
    int currentDigit;
      
    while (num > 0)
    {
        currentDigit = num % 10;
        sum += currentDigit;
        num = (num - currentDigit) / 10;    
    }
    return sum;
    
}

Write("Введите число N: ");
int N = int.Parse(ReadLine());
WriteLine($"Сумма цифр в числе = {getSumOfDigits(N)}");