// ЗАДАЧА 1
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int m, int n, int minValue, int maxValue)
// {
//     double[,] newArray = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue) / 10.0;
//         }
//     }
//     Console.WriteLine($"m = {m}, n = {n}.");
//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// Show2DArray(Create2DRandomArray(m, n, min, max));



// <<--------->>



// ЗАДАЧА 2
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindArrayElement(int[,] array, int rowIndex, int columnIndex)
// {
//     if (rowIndex < 0 | rowIndex > array.GetLength(0) - 1 | columnIndex < 0 | columnIndex > array.GetLength(1) - 1)
//     {
//         Console.WriteLine($"Элемент ({rowIndex}, {columnIndex}) не существует в массиве");
//     }
//     else
//     {
//         Console.WriteLine($"Значение элемента массива ({rowIndex}, {columnIndex}) -> " + array[rowIndex, columnIndex]);
//     }
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс строки массива");
// int rowIndex = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс колонки массива");
// int columnIndex = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(min, max, rows, columns);
// Show2DArray(myArray);
// FindArrayElement(myArray, rowIndex, columnIndex);



// <<--------->>



// ЗАДАЧА 3
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ColumnsMeanSum(int[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)} ");
    }
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(min, max, rows, columns);
Show2DArray(myArray);
Console.Write($"Среднее арифметическое каждого столбца: ");
ColumnsMeanSum(myArray);