//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
System.Console.WriteLine("введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
MinSumElements(array);



void MinSumElements(int[,] array)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        sum += array[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"{minSum + 1} строка");
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}