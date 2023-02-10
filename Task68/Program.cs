/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

//В примере из постановки задачи ошибка. A(2,3) = 9, а вот А(3,2) = 29

using System;
using static System.Console;

Clear();
Write("Введите m: ");
int M = int.Parse(ReadLine());
Write("Введите n: ");   
int N = int.Parse(ReadLine());
WriteLine($"A(m, n) = {Akkerman(M, N)}");


int Akkerman(int m, int n)
{
    if (m == 0 && n == 0) return 1;
    if (m == 0 && n > 0)return (n + 1);
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}