/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//Предполагаем, что пользователь вводит массив с клавиатуры.

using System;
using static System.Console;

Clear();
Write("Задайте массив через пробел: ");
string stringArray = ReadLine();
int[] intArray = getArrayFromString(stringArray);
WriteLine(String.Join(", ", intArray));
int difference = miniMax(intArray, "max") - miniMax(intArray, "min");
WriteLine($"Разница между min и max элементами массива = {difference}");

int[] getArrayFromString(string stringArray)
{
    string[] incomingArray = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] resultArray = new int[incomingArray.Length];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = int.Parse(incomingArray[i]);
    }
    return resultArray;
}

int miniMax(int[] array, string what)//возвращает минимум (what = min) или максимум (what = max)
{
    int value = array[0];
    if (what == "min")
    {
        for (int i = 1; i < array.Length; i++)
        {
            if(array[i] < value) value= array[i];
        }
    }
    else if (what == "max")
    {
        for (int i = 1; i < array.Length; i++)
        {
            if(array[i] > value) value = array[i];
        }
    }
    return value;
}