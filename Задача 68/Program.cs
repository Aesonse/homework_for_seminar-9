/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
using System;
using static System.Console;

Clear();

int m = DataInput("m");
int n = DataInput("n");
WriteLine($"A({m},{n}) = {RecursAkkerman(m, n)}");

int DataInput(string message)
{
    Write("Введите " + message + ": ");
    int result = int.Parse(ReadLine());
    return result;
}

int RecursAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return RecursAkkerman(m - 1, 1);
    return RecursAkkerman(m - 1, RecursAkkerman(m, n - 1));
}