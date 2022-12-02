/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void sumPrint(int number, int count, int sum)
{
    if (count <= number)
    {
        sum += count;
        sumPrint(number, count + 1, sum);
    }
    else System.Console.WriteLine(sum);
}




int userNumberM = GetNumber("Введите число M:");
int userNumberN = GetNumber("Введите число N:");
int summ = 0;
sumPrint(userNumberN, userNumberM, summ);
