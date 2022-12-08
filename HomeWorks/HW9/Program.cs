// ЗАДАЧА 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void Showms(int n)
// {
//     if (n >= 1)
//     {
//         Console.Write(n + " ");
//         Showms(n - 1);
//     }
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"N = {n} -> ");
// Showms(n);



// <<--------->>



// ЗАДАЧА 2
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumNumbers(int M, int N)
// {
//     if (M < N) return N + SumNumbers(M, N - 1);
//     if (M > N) return M + SumNumbers(N, M - 1);
//     return M;
// }

// Console.Write("Введите начало промежутка: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец промежутка: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"M = {m}; N = {n} -> {SumNumbers(m, n)}");



// <<--------->>



// ЗАДАЧА 3
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    if (n == 0 && m > 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
    }
}

Console.Write("Введите начало промежутка: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец промежутка: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {m}; m = {n} -> A(m,n) = {FunctionAkkerman(m, n)}");