/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

using System;
using static System.Console;

Clear();
Write("Введите число: ");
string Number = ReadLine();
int len = Number.Length;
bool result = false;
for (int i = 0; i < len / 2; i++) {
    if (Number[i] == Number[len - 1 - i])
        result = result || true;
}

if (result == true)
  Console.WriteLine("да");
else
    Console.WriteLine("нет");
