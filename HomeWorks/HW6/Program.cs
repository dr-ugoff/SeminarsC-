// ЗАДАЧА 1
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateRandomArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(-1000, 1000);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1)
//         {
//             Console.Write(array[i] + "-> ");
//         }
//         else
//         {
//             Console.Write(array[i] + ", ");
//         }
//     }
// }

// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     Console.WriteLine($"Number positive elements: {count}");
//     return count;
// }

// Console.Write("Input the number of elements in the array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size);
// Console.WriteLine();
// ShowArray(myArray);
// CountPositiveNumbers(myArray);




// ЗАДАЧА 2
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
// ------------------
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

void PointIntersectionLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1 == k2) // k1 и k2 - угловые коэффициенты; если k1 и k2 равны, то прямые параллельны.
    {
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> lines are parallel");
    }
    else
    {
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> point intersection: ({x}; {y})");
    }
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
PointIntersectionLines(b1, k1, b2, k2);