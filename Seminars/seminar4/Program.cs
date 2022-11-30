//ЗАДАЧА 1
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum(int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum = sum + i;
//     }
//     Console.WriteLine($"The sum of all numbers from 1 to {a} is {sum}");
//     return sum;
// }
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// FindSum(number);



//<<------>>//



//ЗАДАЧА 2
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

// int FindNumberOfDigitsNumber(int num)
// {
//     int count = 0;
//     for (count = 0; num > 0; count++)
//     {
//         num = num / 10;
//     }
//     Console.WriteLine($"{count}");
//     return count;
// }
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"The number of digits in the number {number} -> ");
// FindNumberOfDigitsNumber(number);


// Альтернативный способ решения задачи через цикл while...
// int FindNumberOfDigitsNumber(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     Console.WriteLine($"{count}");
//     return count;
// }
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"The number of digits in the number {number} -> ");
// FindNumberOfDigitsNumber(number);



//<<------>>//



// ЗАДАЧА 3
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int FindresultNumber(int num)
// {
//     int result = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         result = result * i;
//     }
//     Console.Write($"{result}");
//     return result;
// }
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{number} -> ");
// FindresultNumber(number);



//<<------>>//



// ЗАДАЧА 4
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Вариант решения с семинара
// void FillArray(int[size])
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//         Console.Write($"{array[i]} ");
//     }
// }
// FillArray(8);


// Мое решение
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]},");
//         position++;
//     }
// }
// int[] array = new int[8];
// FillArray(array);
// Console.Write($"[");
// PrintArray(array);
// Console.Write($"]");


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);