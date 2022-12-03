// ЗАДАЧА 1
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// void FindMinMaxSum(int[] array)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sumPositive = sumPositive + array[i];
//         else sumNegative += array[i];
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Cумма положительных чисел в массиве -> {sumPositive} \nCумма отрицательных чисел в массиве -> {sumNegative}");
// }

// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(a, min, max);
// ShowArray(myArray);
// FindMinMaxSum(myArray);



//<<------>>//



// ЗАДАЧА 2
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] InvertArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(a, min, max);
// ShowArray(myArray);
// Console.WriteLine();
// ShowArray(InvertArray(myArray));



//<<------>>//



// ЗАДАЧА 3
// Задайте массив (методом запроса элементов массива у пользователя). 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

// int[] CreateArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите элемент {i + 1} массива: ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1)
//         {
//             Console.Write(array[i]);
//         }
//         else
//         {
//             Console.Write(array[i] + ", ");
//         }
//     }
// }

// bool FindNumber(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             Console.Write($" -> да");
//             return true;
//         }
//     }
//     Console.Write($" -> нет");
//     return false;
// }

// Console.Write("Введите размер массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(a);
// Console.Write("Введите проверяемое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.Write($"{number}; массив [");
// ShowArray(myArray);
// Console.Write($"]");
// FindNumber(myArray, number);



//<<------>>//



// ЗАДАЧА 4
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// [5, 18, 123, 6, 2] -> 1
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(10, 1000);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
}

void FindNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count++;
    }
    Console.WriteLine(count);
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
Console.WriteLine();
Console.Write($"[");
ShowArray(myArray);
Console.Write($"] -> ");
FindNumber(myArray);