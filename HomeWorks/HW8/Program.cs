// ЗАДАЧА 1
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

// int[,] SelectionSortRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, min, max);
// Show2DArray(myArray);
// myArray = SelectionSortRows(myArray);
// Console.WriteLine();
// Show2DArray(myArray);




// <<--------->>




// ЗАДАЧА 2
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

// void FindRowMinimalSum(int[,] array)
// {

//     int sumMinRow = 0;
//     int sumRow = 0;
//     int indexMinSumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         sumRow = sumRow + array[0, i];
//     }
//     sumMinRow = sumRow;
//     Console.WriteLine("Сумма строки 1: " + sumRow + " ");
//     for (int j = 1; j < array.GetLength(0); j++)
//     {
//         int sum = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             sum = sum + array[j, k];
//         }
//         Console.WriteLine("Сумма строки "+ (j + 1) + ": " + sum + " ");
//         if (sum < sumMinRow)
//         {
//             sumMinRow = sum;
//             indexMinSumRow = j;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Строка с наименьшей суммой элементов: {indexMinSumRow + 1}");
//     Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {indexMinSumRow}");
// }

// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, min, max);
// Show2DArray(myArray);
// Console.WriteLine();
// FindRowMinimalSum(myArray);
// Console.WriteLine();




// <<--------->>




// ЗАДАЧА 3
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

// void ResultMatrix(int[,] array1, int[,] array2, int[,] resultMatrix)
// {
//  for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < array1.GetLength(1); k++)
//       {
//         sum = sum + array1[i,k] * array2[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// Console.Write("Введите минимальное значение элементов матриц: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элементов матриц: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк матрицы №1: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы №1 (оно же число строк матрицы №2): ");
// int columns1rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы №2: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// Console.WriteLine("Матрица №1: ");
// int[,] myArray1 = Create2DRandomArray(rows1, columns1rows2, min, max);
// Show2DArray(myArray1);

// Console.WriteLine();
// Console.WriteLine("Матрица №2: ");
// int[,] myArray2 = Create2DRandomArray(columns1rows2, columns2, min, max);
// Show2DArray(myArray2);

// Console.WriteLine();
// Console.WriteLine("Результирующая матрица: ");
// int[,] resultArray = new int[rows1, columns2];
// ResultMatrix(myArray1, myArray2, resultArray);
// Show2DArray(resultArray);
// Console.WriteLine();




// <<--------->>




// ЗАДАЧА 4
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            {
                Console.Write($" {array[i, j]} ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

int[,] FillSpiralArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
            j++;
        }
        else
        {
            if (i < j && i + j >= array.GetLength(0) - 1)
            {
                i++;
            }
            else
            {
                if (i >= j && i + j > array.GetLength(1) - 1)
                {
                    j--;
                }
                else
                {
                    i--;
                }
            }
        }
    }
    return array;
}

Console.WriteLine();
Console.WriteLine("Спирально заполненный массив 4х4");
int[,] myArray = new int[4, 4];
Show2DArray(FillSpiralArray(myArray));
Console.WriteLine();

