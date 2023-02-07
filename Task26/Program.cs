/*Напишите метод, который принимает на вход число и выдает количество цифр в числе*/

using System;
using static System.Console;

int getNumberOfDigits(int num) 
{
    int number = 1;
    int divider = 10;
    int remainder = num/divider;
    //WriteLine($"remainder = {remainder}, divider = {divider}, number = {number}");
    while ((remainder > 0) & (num != 0))
    {
        divider *= 10;
        remainder = num/divider;
        number += 1;
        //WriteLine($"remainder = {remainder}, divider = {divider}, number = {number}");
    }
    return number;
}

Write("Введите число N: ");
int N = int.Parse(ReadLine());
WriteLine($"Количество цифр  = {getNumberOfDigits(N)}");
