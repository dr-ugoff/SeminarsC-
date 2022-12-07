// ЗАДАЧА 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumber(int n)
// {
//     if (n >= 1)
//     {
//         ShowNumber(n-1);
//         Console.Write(n + " ");
//     }
// }
// ShowNumber(5);



// <<--------->>



// ЗАДАЧА 2
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int FindSum(int num)
// {
//     if ( num != 0)
//     {
//         return FindSum(num/10) + num % 10;
//     }
//     else
//     {
//         return num;
//     }
// }

// int sum = FindSum(456);
// Console.WriteLine(sum);



// <<--------->>



// Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void FindInterval(int start, int finish)
// {
//     if (start != finish)
//     {
//         if (finish > start)
//         {
//             FindInterval(start, finish - 1);
//             Console.Write(finish + " ");
//         }
//         else
//         {
//             FindInterval(finish, start - 1);
//             Console.Write(start + " ");
//         }
//     }
//     else
//     {
//         Console.Write(start + " ");
//     }
// }

// Console.Write("Введите начало промежутка: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец промежутка: ");
// int finish = Convert.ToInt32(Console.ReadLine());
// FindInterval(start, finish);




// <<--------->>



//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

// void FinPowerNumber(int a, int b)
// {

// }

int FindPowerNumber(int A, int B)
{
    if (B == 0)
    return 1;
    else
    {
        return A * FindPowerNumber(A, B - 1);
    }
    return A;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"A = {a}, B = {b} -> {FindPowerNumber(a, b)}");