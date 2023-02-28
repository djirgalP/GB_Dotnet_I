/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

//Задача 65 на семинаре точно такая же, поэтому я добавила вторую функцию без рекурсии
using System;
using static System.Console;

Clear();
Write("Введите M: ");
int M = int.Parse(ReadLine());
Write("Введите N: ");   
int N = int.Parse(ReadLine());
WriteLine("Вывод рекурсией: " + PrintNumbersRecursion(M, N));
WriteLine("Вывод без рекурсии: " + PrintNumbers(M, N));

string PrintNumbersRecursion(int from, int to)
{
    if (from == to) return from.ToString();
    return(from + ", " + PrintNumbersRecursion(from + 1, to));
}

string PrintNumbers(int from, int to)
{
    int[] array = new int[to - from + 1];
    for (int i = 0; i < to - from + 1; i++) array[i] = from + i;
    return String.Join(", ", array);
}