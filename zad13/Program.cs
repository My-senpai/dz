/*Задача 63:
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
/*
int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine()); ;
    return userNumber;
}

string Stringrecursion(int number)
{
    if (number == 1) return number.ToString();

    return Stringrecursion(number - 1) + " " + number;
}

int userNumber = GetNumber("Введите число: ");
Console.WriteLine();
Console.Write(Stringrecursion(number: userNumber));*/














// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

/*
int GetNumber(string msg)
{
Console.WriteLine(msg);
int userNumber = Convert.ToInt32(Console.ReadLine());
return userNumber;
}

void PrintNimbers(int number, int count)
{
if(count<=number)
{
Console.Write($"{count} ");
PrintNimbers(number, count+1);
}
}

int userNumberM = GetNumber("Введите число M:");
int userNumberN = GetNumber("Введите число N:");
PrintNimbers(userNumberN,userNumberM);*/







// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

/*
int GetNumber(string msg)
{
Console.WriteLine(msg);
int userNumber = Convert.ToInt32(Console.ReadLine());
return userNumber;
}

int SumOfDigit(int userNumber, int sum)
{
if(userNumber%10==0) return sum;
else{
sum = sum + userNumber%10;

}
return SumOfDigit(userNumber/10, sum);
}

int userNmbr = GetNumber("Введите число: ");
int sum = 0;
int sumOfDigit = SumOfDigit(userNmbr,sum);
Console.WriteLine(sumOfDigit);
*/









// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int GetNumber(string msg)
{
Console.WriteLine(msg);
int userNumber = Convert.ToInt32(Console.ReadLine());
return userNumber;
}

int DegreeOfDigit(int numberA, int numberB)
{
if(numberB == 1) return numberA;
else{
return numberA*DegreeOfDigit(numberA,numberB - 1);
}
}

int userNumberM = GetNumber("Введите число A:");
int userNumberN = GetNumber("Введите число B:");

int result = DegreeOfDigit(userNumberM, userNumberN);
Console.WriteLine(result);




