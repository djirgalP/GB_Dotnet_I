/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

//Предложим пользователю задавать длину массива, а массив будем заполнлять от -100 до 100

using System;
using static System.Console;

Clear();
Write("Задайте длину массива: ");
int length = int.Parse(ReadLine());
int[] array = getArray(length, -100, 100);
WriteLine(String.Join(", ", array));
int sum = 0;
for(int i = 1; i < length; i = i + 2)
{
    sum += array[i];
}
WriteLine($"Сумма элементов на нечётных позициях = {sum}");

int[] getArray(int size, int min, int max) 
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}