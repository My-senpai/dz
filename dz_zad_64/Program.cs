/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


int GetNumber(string x)
{
    Console.Write(x);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

string rekursia(int number)
{
    string str = string.Empty;
    if (number == 1) return number.ToString();
    return number + " " + rekursia(number - 1);
}

int k = GetNumber("Введите число ");
System.Console.WriteLine();
System.Console.WriteLine(rekursia(k));

