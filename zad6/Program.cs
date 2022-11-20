/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int GetNumber(string msg)
{
    System.Console.Write(msg);
    int message = int.Parse(Console.ReadLine());
    return message;
}

void Check(int a, int b, int c)
{
    if (a < (b + c) && c < (a + b) && b < (a + c))
        System.Console.WriteLine("такой треугольник есть");
    else
        System.Console.WriteLine("такого треугольника нет");
}




int numberA = GetNumber("введите число 1: ");
int numberB = GetNumber("введите число 2: ");
int numberC = GetNumber("введите число 3: ");

Check(numberA, numberB, numberC);