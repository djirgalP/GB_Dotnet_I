/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

//Предложим пользователю задавать длину массива

using System;
using static System.Console;

Clear();
Write("Задайте длину массива: ");
int length = int.Parse(ReadLine());
int[] array = getArray(length, 100, 999);
WriteLine(String.Join(", ", array));
int counter = 0;
foreach (var item in array)
{
    if (item % 2 == 0) 
    {
        counter += 1;
    }
}
WriteLine($"Количество четных элементов = {counter}");

int[] getArray(int size, int min, int max) 
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}