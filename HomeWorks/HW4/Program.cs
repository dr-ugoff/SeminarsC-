// ЗАДАЧА1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exponentiation(int a, int b)
{
    double result = 1;
    for (int i = 1; i <= Math.Abs(b); i++)
    {
        result = result * a;
    }
    if (b > 0)
    {
        Console.Write($"The number {a} raised to the power of {b} ({a}^{b}) -> {result}"); // Степень положительная
    }
    else
    {
        Console.Write($"The number {a} raised to the power of {b} ({a}^{b}) -> {1 / result}"); // Степень отрицательная
    }
    return result;
}
Console.Write($"Input the number \"A\" base: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input the number \"B\" degree: ");
int B = Convert.ToInt32(Console.ReadLine());
Exponentiation(A, B);



//<<------>>//



// ЗАДАЧА 2
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int num)
{
    int inc = 1;
    int digit = 1;
    int sum = 0;
    while (num / inc > 0)
    {
        digit = num / inc % 10;
        sum = sum + digit;
        inc = inc * 10;
    }
    Console.Write($"The sum of all the digits in \"{num}\" is -> {sum}");
    return sum;
}
Console.Write($"Input any number: ");
int number = Convert.ToInt32(Console.ReadLine());
SumDigits(number);



//<<------>>//



// ЗАДАЧА 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    Console.Write("Generated random array elements: ");
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
        if (i == size - 1)
        {
            Console.WriteLine(newArray[i]);
        }
        else
        {
            Console.Write(newArray[i] + ", ");
        }
    }
    return newArray;
}

void PrintArray(int[] array)
{
    Console.Write("The resulting array -> [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + "]");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }

}

Console.Write("Input the length of the array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the minimum value of the array element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the maximum value of the array element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintArray(FillArray(length, min, max));