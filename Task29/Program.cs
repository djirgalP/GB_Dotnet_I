/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]*/

using System;
using static System.Console;

Clear();
Write("Введите длину создаваемого массива: ");
int N = int.Parse(ReadLine());
WriteLine($"[{String.Join(", ", getRandomArray(N))}]");

int[] getRandomArray(int size) 
{
    int[] resultArray = new int[size];
      
    for(int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(0, 100);
    }
    return resultArray; 
}

