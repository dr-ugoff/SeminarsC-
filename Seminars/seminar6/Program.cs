// ЗАДАЧА 1
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// ShowArray(ReverseArray(myArray));



// <<--------->>



//ЗАДАЧА 2
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

// bool CheckTriangle(int a, int b, int c)
// {
//     if (a + b > c && b + c > a && a + c > b)
//         return true;
//     return false;
// }

// int CheckNumber()
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x <= 0) return CheckNumber();
//     else return x;
// }

// Console.WriteLine("Input the length of side A: ");
// int a = CheckNumber();
// Console.WriteLine("Input the length of side B: ");
// int b = CheckNumber();
// Console.WriteLine("Input the length of side C: ");
// int c = CheckNumber();

// Console.WriteLine(CheckTriangle(a, b, c));



// <<--------->>



// ЗАДАЧА 3
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
// Числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
// [0, 1,2, 3, 5, 8, 13, ... ]

// int[] Fibonachi(int a, int b, int n)
// {
//     int[] newArray = new int[n];
//     newArray[0] = a;
//     newArray[1] = b;
//     for (int i = 2; i < n; i++)
//     {
//         newArray[i] = newArray[i - 1] + newArray[i - 2];
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write($"Числа Фибоначчи -> ");

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число Фибоначчи:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число Фибоначчи:");
// int b = Convert.ToInt32(Console.ReadLine());
// ShowArray(Fibonachi(a, b, n));



// <<--------->>



// ЗАДАЧА 4
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string TransformToBinary(int num)
{
string result = String.Empty;
int binarynum;
while (num > 0)
{
binarynum = num % 2;
result = binarynum + result;
num = num / 2;
}
return result;
}
Console.WriteLine(TransformToBinary(13));
Console.WriteLine("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(TransformToBinary(number));
