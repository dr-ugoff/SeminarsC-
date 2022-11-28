// ЗАДАЧА 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void NumPolyndromYesNo (int num)
{
    if (num / 10000 >= 1 && num / 10000 < 10) // проверка, что число пятизначное
    {
        if (num / 10000 % 10 == num % 10 && num / 1000 % 10 == num /10 % 10) //проверка: 1 и 5 числа равны, также 2 и 4 числа равны
        {
            Console.WriteLine($"Is number {num} a polyndrom? -> yes");
        }
        else
        {
            Console.WriteLine($"Is number {num} a polyndrom? -> no");
        }
    }
    else
    {
        Console.WriteLine($"You entered a non-five-digit number. Please, inpute five-digit number.");
    }
}

Console.Write($"Input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
NumPolyndromYesNo (number);


//<<------>>//


// ЗАДАЧА 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void FindDistanceTwoPoints (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double distance = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2);
//     Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> distance beetween A and B is {distance}");
// }
// Console.Write($"Input the X coordinate of point A: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Input the Y coordinate of point A: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Input the Z coordinate of point A: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Input the X coordinate of point B: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Input the Y coordinate of point B: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Input the Z coordinate of point B: ");
// double z2 = Convert.ToDouble(Console.ReadLine());
// FindDistanceTwoPoints(x1, y1, z1, x2, y2, z2);


//<<------>>//


// ЗАДАЧА 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void FindСubeAllNum (int num)
// {
//     if (num == 0)
//     {
//         Console.Write($"Please, input a number other than \"{num}\""); //если введен "0", просим ввести отличное от нуля число
//     }
//     else
//     {
//         for (int i = 1; i <= num; i++)
//         {
//             if (i == num)
//             {
//                 Console.Write($"{i * i * i}"); //не выводим последнюю запятую
//             }
//             else
//             {
//                 Console.Write($"{i * i * i}, ");
//             }
//         }
//     }
// }
// Console.Write($"Input any integer: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.Write($"{N} -> ");
// FindСubeAllNum (N);