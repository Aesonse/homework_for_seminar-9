/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


using System;
using static System.Console;

Clear();

int N = DataInput("N");
RecursPrintNumbers(N);

int DataInput(string message)
{
    Write("Введите " + message + ": ");
    int result = int.Parse(ReadLine());
    return result;
}

void RecursPrintNumbers(int num)
{
    Write(num);
    if (num > 1)
    {
        Write(", ");
        RecursPrintNumbers(num - 1);
    }
}