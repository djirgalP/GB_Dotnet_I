/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

/*Полагаю, что решить надо через двумерный массив k1 * x + b1 = k2 * x + b2
(k1-k2)x = (b2-b1)
x = (b2-b1)/(k1-k2)
y = k1*x + b1
5x + 2 = 9x + 4
-4x = 2 => x = -0.5
y = 5 * x + 2 => y = -0,5
y = 9 * x + 4 => y = -0,5
ОШИБКА в ПРИМЕРЕ из постановки задачи, где (-0,5; 5,5) т.е. будто бы y = 5,5 а не 0,5 !!!!
*/

using System;
using static System.Console;

Clear();
Write("Введите b1: ");
double b1 = double.Parse(ReadLine());
Write("Введите k1: ");
double k1 = double.Parse(ReadLine());
Write("Введите b2: ");
double b2 = double.Parse(ReadLine());
Write("Введите k2: ");
double k2 = double.Parse(ReadLine());
intersection(b1, k1, b2, k2);

void intersection(double b1, double k1, double b2, double k2)
{
    //float[,] point = new int[1, 2];
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    WriteLine("(" + x + "; " + y + ")");
     
}