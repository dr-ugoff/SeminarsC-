// ЗАДАЧА 1
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
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

// void FindEvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) count++;
//     }
//     Console.WriteLine($"{count} even numbers in this massive");
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(size);
// Console.WriteLine();
// Console.Write($"[");
// ShowArray(myArray);
// Console.Write($"] -> ");
// FindEvenNumber(myArray);



// <<--------->>



// ЗАДАЧА 2
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(-100, 100);
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

// void SumElementsOddPositions(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 == 1) sum = sum + array[i];
//     }
//     Console.WriteLine($"Sum of elements at odd positions is {sum}");
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(size);
// Console.WriteLine();
// Console.Write($"[");
// ShowArray(myArray);
// Console.Write($"] -> ");
// SumElementsOddPositions(myArray);



// <<--------->>



// ЗАДАЧА 3
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int size)
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(1, 100);
    }
    return newArray;
}

void ShowArray(double[] array)
{
    for (int i = 1; i < array.Length; i++)
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

void DifferenceMaxMinElements(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else
        {
            if (array[i] < min)
                min = array[i];
        }
    }
    Console.WriteLine(max - min);
    Console.WriteLine($"max -> {max}");
    Console.WriteLine($"min -> {min}");
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(size);
Console.WriteLine();
Console.Write($"[");
ShowArray(myArray);
Console.Write($"] -> ");
DifferenceMaxMinElements(myArray);
