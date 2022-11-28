// ЗАДАЧА 1
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

// double FindQuarter(double x, double y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }
// Console.Write("Input coordinate X: ");
// double x = Convert.Todouble(Console.ReadLine());
// Console.Write("Input coordinate Y: ");
// double y = Convert.Todouble(Console.ReadLine());
// double result = FindQuarter(x, y);
// Console.WriteLine($"Quarter number of our podouble is {result}");


//<<------>>//


//ЗАДАЧА 2
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindCoordinats(double quarter)
// {
//     if (quarter < 1 || quarter > 4) Console.WriteLine($"Quarter number can only be 1, 2, 3 or 4. Please, input correct number.");
//     if (quarter == 1) Console.WriteLine($"Coordinate range in I quarter (x > 0 ; y > 0)");
//     if (quarter == 2) Console.WriteLine($"Coordinate range in II quarter (x < 0 ; y > 0)");
//     if (quarter == 3) Console.WriteLine($"Coordinate range in III quarter (x < 0 ; y < 0)");
//     if (quarter == 4) Console.WriteLine($"Coordinate range in IV quarter (x > 0 ; y < 0)");
// }
// Console.Write("Input number of quarter coordinates: ");
// double quart = Convert.ToDouble(Console.ReadLine());
// FindCoordinats(quart);


//<<------>>//


//ЗАДАЧА 3
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21


// void FindDistanceTwoPoints (double x1, double y1, double x2, double y2)
// {
//     double distance = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)), 2);
//     Console.WriteLine($"A ({x1}, {y1}); B({x2}, {y2}) -> distance beetween A and B is {distance}");
// }
// Console.Write($"Input the X coordinate of point A: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Input the Y coordinate of point A: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Input the X coordinate of point B: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Input the Y coordinate of point B: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// FindDistanceTwoPoints(x1, y1, x2, y2);


//<<------>>//


//ЗАДАЧА 4
// Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

void FindSqrtNum (int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} - {i * i}");
    }
}
Console.Write($"Input any integer: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Num - Num square");
FindSqrtNum (N);