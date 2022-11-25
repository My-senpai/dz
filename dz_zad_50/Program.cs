/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] initArray()
{
    int[,] array = new int[5, 5];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rnd.Next(100);
        }

    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] + "\t"}");
        }
        Console.WriteLine();
    }
}

int[,] array = initArray();
PrintArray(array);

System.Console.WriteLine("Введите координаты А");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координаты Б");
int b = int.Parse(Console.ReadLine());




if (array.GetLength(0) - 1 < a || array.GetLength(1) - 1 < b)
{
    Console.WriteLine("нет такого элемента");
    
}
else
    Console.WriteLine($"элемент с индексами [{a}, {b}] равен: {array[a, b]}");










