/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using System;
using static System.Console;

Clear();

int M = DataInput("M");
int N = DataInput("N");
WriteLine($"Сумма равна {RecursSum(M, N)}");

int DataInput(string message)
{
    Write("Введите " + message + ": ");
    int result = int.Parse(ReadLine());
    return result;
}

int RecursSum(int M, int N)
{
    if (M == N) return M; 
    return N + RecursSum(M, N - 1);
}