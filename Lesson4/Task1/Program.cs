﻿// Создать двумерный массив с размерами
// 3 х 5, состоящий их целых чисел.
// Вывести его элементы на экран.

// int[,] matrix = new int[3, 5];

// Random rand = new Random();

// for ( int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = rand.Next(1, 11);
//     }
// }

// for ( int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write($"{matrix[i, j]} ");
//     }
//     System.Console.WriteLine();
// }

// Таже задача только решение функцией

int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rand = new Random();

    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 11);
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

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);