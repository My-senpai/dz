/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


int GetNumber(string msg)
{
    System.Console.Write(msg);
    int message = int.Parse(Console.ReadLine());
    return message;
}

int check(int n)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (GetNumber("Введите число ") > 0) count ++;
        
    }
    return count;
}

int number = GetNumber("ввидете количество чисел ");
System.Console.WriteLine($"вот столько положительных чисел {check(number)}");









