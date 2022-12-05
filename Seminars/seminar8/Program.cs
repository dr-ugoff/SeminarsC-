// ЗАДАЧА 1
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

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

// int[,] ReverseRows(int[,] array, int row1, int row2)
// {
//     if (row1 > array.GetLength(0) || row2 > array.GetLength(0))
//     {
//         return array;
//     }

//     else
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
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

// Console.Write("Введите номер первой строки которую хотите поменять: ");
// int r1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер второй строки которую хотите поменять: ");
// int r2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, min, max);
// Show2DArray(myArray);
// myArray = ReverseRows(myArray, r1, r2);
// Console.WriteLine();
// Show2DArray(myArray);



// <<--------->>



// Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7


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

// int[,] DiagonalReverseArray(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.Write("Невозможно выполнить. Создайте квадратный массив.");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(0); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
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
// myArray = DiagonalReverseArray(myArray);
// Console.WriteLine();
// Show2DArray(myArray);



// <<--------->>



// ЗАДАЧА 3
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент,
// то есть удалаем и строку и столбец в которой находится этот элемент

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

int[,] FindMinValue(int[,] array)
{
    int row = 0;
    int column = 0;
    int minValue = array[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
                row = i;
                column = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, column] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[row, j] = 0;
    }
    return array;
}

Console.Write("Введите минимальное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(rows, columns, min, max);
Show2DArray(myArray);
myArray = FindMinValue(myArray);
Console.WriteLine();
Show2DArray(myArray);