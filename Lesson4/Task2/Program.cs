﻿// Назовём число "интересным" если его сумма
// цифр чётная. 
// Создать двумерный массивб состоящий из 
// целых чисел. Вывести на экран "интересные"
// элементы массива.

int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rand = new Random();

    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix (int[,] matrix)
{
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (isInteresting(e) = true)
    {
        System.Console.WriteLine(e);
    }
}


bool isInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if(sumOfDigits % 2 == 0)
    {
        return true;
    }
    
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}