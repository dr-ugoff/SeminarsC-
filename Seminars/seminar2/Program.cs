//Задача 1
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

// int FindBiggestDigit (int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if (ed > dec)
//     {
//         return ed;
//     }
//     else
//     {
//         return dec;
//     }
// }

// int rand = new Random().Next(10,100);
// int result = FindBiggestDigit(rand);
// Console.WriteLine($"Your number -> {rand}"); // Вывод сгенерированного случайного числа
// Console.WriteLine($"The biggest digit -> {result}"); // Вывод наибольшей цифры сгенерированного числа


//<<------>>//


//Задача2
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

// int CutSecondDigit (int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     int newNum = sot *10 + ed;
//     return newNum;
// }

// int rand = new Random().Next(100,1000);
// int result = CutSecondDigit(rand);
// Console.WriteLine($"Your number -> {rand}");
// Console.WriteLine($"New number -> {result}");


//<<------>>//


//Задача 3
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

// void CutSecondDigit (int num1, int num2)
// {
//     int result = num1 % num2;
//     if (result == 0)
//     {
//     Console.WriteLine($"{num1}, {num2} -> is a multiple");
//     }
//     else
//     {
//     Console.WriteLine($"{num1}, {num2} -> is not a multiple, remainder {result}");
//     }
// }
    
// Console.WriteLine("Input number 1");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number 2");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// CutSecondDigit(firstNum, secondNum);


//<<------>>//


// Задача 4
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

bool MultipleOf (int num)
{
    if (num % 7 == 0 || num % 23 == 0)
    {
        Console.WriteLine($"{num} -> yes");
        return true;
    }
    else
    {
        Console.WriteLine($"{num} -> no");
        return false;
    }
}
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
MultipleOf(number);