// ЗАДАЧА 1 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5;  b = 7  -> max = 7
// a = 2;  b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Input number 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int b = Convert.ToInt32(Console.ReadLine());
int min = a;
int max = a;
if (a > b)
{
    min = b;
}
else
{
    max = b;
}
Console.Write($"min = {min}, max = {max}");


//<<------>>//


// ЗАДАЧА 2
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input number 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number 3");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (max < num2) max = num2;
// if (max < num3) max = num3;
// Console.WriteLine($"max = {max}");


//<<------>>//


// ЗАДАЧА 3
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4  -> да
// -3 -> нет
// 7  -> нет

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int even = num % 2;
// if (even == 0) 
// {
//     Console.WriteLine($"{num} is even number -> yes");
// }
// else
// {
//     Console.WriteLine($"{num} is odd number -> no");
// }


//<<------>>//


// ЗАДАЧА 4
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// while (count <= num)
// {
//     Console.WriteLine(count);
//     count+=2;
// }