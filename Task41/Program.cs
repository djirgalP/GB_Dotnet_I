/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

//Предполагаем, что число M задавать пользователю заранее не надо.

using System;
using static System.Console;

Clear();
Write("Введите массив целых чисел через запятую: ");
string stringArray = ReadLine();
int[] intArray = getArrayFromString(stringArray);
WriteLine(String.Join(", ", intArray));
WriteLine($"Количество чисел больше нуля = {getPositiveNumbers(intArray)}");

int[] getArrayFromString(string stringArray)
{
    string[] incomingArray = stringArray.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] resultArray = new int[incomingArray.Length];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = int.Parse(incomingArray[i]);
    }
    return resultArray;
}

int getPositiveNumbers(int[] array)
{
    int number = 0;
    foreach(int value in array)
    {
        if (value > 0) number += 1;
    }
    
    return number;
}