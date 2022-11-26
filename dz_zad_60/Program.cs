int x = GetNumber("Введите размер x: ");
int y = GetNumber("Введите размер y: ");
int z = GetNumber("Введите размер z: ");

int GetNumber(string message)
{
    Console.Write(message);
    int useNum = Convert.ToInt32(Console.ReadLine()); ;
    return useNum;
}

    Random rnd = new Random();
void PrintArray(int[,,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            for (int k = 0; k < tempArray.GetLength(2);k++)
            {
            Console.Write($"{tempArray[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] FillArray(int x, int y, int z)
{
    int[,,] tempArray = new int[x, y, z];
    int s=rnd.Next(10,20);
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {   
            for (int k = 0; k <tempArray.GetLength(2);k++)
            {
                tempArray[i, j, k] = s;
                s=s+rnd.Next(0, 10);
            }
        }
    }

    return tempArray;
}

int[,,] arr = FillArray(x,y,z);
PrintArray(arr);