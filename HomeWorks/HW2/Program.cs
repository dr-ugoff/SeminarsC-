// Задача 1
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigitOfNumber (int num)
{
    if (num < 0) num = -1 * num;
    int secondDigit = (num / 10) % 10;
    Console.WriteLine($"The second digit is {secondDigit}");
    return secondDigit;
}
Console.WriteLine("Input three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
SecondDigitOfNumber(number);


//<<------>>//


// ЗАДАЧА 2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdDigitInNumber(int num)
// {
//     int result = -1;
//     if (num > 99)
//     {
//         while (num > 999)
//         {
//             num = num / 10;
//         }
//         result = num % 10;
//     }
//     else
//     {
//         Console.WriteLine($"{num} -> no third digit");
//     }
//     Console.WriteLine($"{num} -> third digit is {result}");
//     return result; 
// }
// Console.Write("Input any number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// ThirdDigitInNumber(number);



//<<------>>//


// ЗАДАЧА 3
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// bool HolidayYesNo (int num)
// {
//     if (num == 6 || num == 7)
//     {
//         Console.WriteLine($"{num} -> yes (it's a holiday)");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine($"{num} -> no (it's not a holiday)");
//         return false;
//     }
// }
// Console.Write("Input the day of the week (1-7): ");
// int day = Convert.ToInt32(Console.ReadLine());
// HolidayYesNo(day);