// Пример 1 (вывести число, которое ввел пользователь)

// Console.WriteLine("Input number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a);

//<<------>>//


// Пример 2 (вывести квадрат числа введенного )

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int square = num * num;
// Console.WriteLine($"Square {num} is {square}");


//<<------>>//


// Пример 3 (Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго)
// a = 25; b = 5  -> да
// a = 2;  b = 10 -> нет
// a = 9;  b = -3 -> да
// a = -3; b = 9  -> нет

// Console.WriteLine("Input number 1");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number 2");
// int b = Convert.ToInt32(Console.ReadLine());
// int square = b * b;
// if (square == a)
// {
//     Console.WriteLine($"{a} is square of {b}");
// }
// else
// {
//     Console.WriteLine($"{a} is not square of {b}");
// }


//<<------>>//


// Задача 1 (Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N)
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = -1 * num;
// while (count <= num)
// {
//     Console.WriteLine(count);
//     count++;
// }


//<<------>>//


// Задача 2 (Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа)
// 456 -> 6
// 782 -> 2
// 918 -> 8)

Console.WriteLine("Input three-digit number");
int num = Convert.ToInt32(Console.ReadLine());
int lastdig = num % 10;
if (lastdig < 0) lastdig = -1 * lastdig;
Console.WriteLine($"The last digit is {lastdig}");

// Альтернативный вариант решения из семинара в zoom
// Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Abs(num) % 10);
