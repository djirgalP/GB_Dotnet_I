/*Задать массив из 12 элементов и заполнить случайными числами из промежутка [-9,9]. 
Найти сумму отрицательных и положительных чисел.*/

using System;
using static System.Console;

Clear();
int[] array = getArray(12, -9, 9);
WriteLine(String.Join(", ", array));
int positiveSum = 0;
int negativeSum = 0;
foreach (var item in array)
{
    if (item > 0) 
    {
        positiveSum += item;
    }
    else
    {
        negativeSum += item;
    }
}
WriteLine($"Сумма положительных элементов = {positiveSum}, Сумма отрицательных элементов = {negativeSum}");

int[] getArray(int size, int min, int max) 
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}