/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] PositiveArray()
{
    int[] result = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 101);
    }
    return result;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void check(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        sum = (array[i]) + sum;
        
    }
    System.Console.WriteLine(sum);
}


int[] arry = PositiveArray();
Print(arry);
check(arry);














