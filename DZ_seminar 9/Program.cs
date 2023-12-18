/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// 1 вариант решения

// int num = new Random().Next(1, 25);
// int endNum = 1;
// int[] collections = new int[num];

// PrintNumbers(num, endNum);

// void PrintNumbers(int start, int end)
// {
//     if(start < end)
//     {
//         Console.WriteLine($"[{String.Join(", ", collections)}]");
//     }
//     else if (start >= end)
//     {
//         collections[collections.Length - start] = start;
//         PrintNumbers(--start, end);
//     }
// }

// // 2 вариант решения

// int num = new Random().Next(-2, 15);
// int endNum = 1;

// Console.WriteLine($"[{PrintNumbers(num, endNum)}]");

// string PrintNumbers(int start, int end)
// {
//     if (start <= 0)
//     {
//         return "Число меньше или равно 0";
//     } 
//     else if (end >= start)
//     {
//         return end.ToString();
//     } 
//     return (PrintNumbers(num, ++endNum) + ", " + end ); 
// }

// 2,5 вариант решения, с дробными числами

// double num = new Random().Next(1, 11);
// double endNum = 1;
// Random rnd = new Random();
// double step = 0.25;

// Console.WriteLine($"[{PrintNumbers(num, endNum)}]");

// string PrintNumbers(double start, double end)
// {
//     // if (start <= 0)
//     // {
//     //     return "Число меньше или равно 0";
//     // } 
//     if (start <= end)
//     {
//         return end.ToString();
//     } 
//     return (start + " | " + PrintNumbers(Math.Round((start - step), 2), endNum)); 
// }

//***********************************************************************************************************************

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// 1 вариант решения

// int num1 = new Random().Next(1, 5);
// int num2 = new Random().Next(5, 11);
// Console.WriteLine($"num1 = {num1}, num2 = {num2}");
// int res = 0;
// Summator(num1, num2);

// void Summator(int a, int b)
// {
//     if (a <= b)
//     {
//         res += a;
//         Summator(++num1, num2);
//     }
//     if (a == b)
//     {
//         Console.WriteLine(res);
//     }
// }

// 2 вариант решения

// int num1 = new Random().Next(1, 5);
// int num2 = new Random().Next(5, 11);
// Console.WriteLine($"num1 = {num1}, num2 = {num2}");

// Summator(num1, num2);
// Console.WriteLine(Summator(num1, num2));

// int Summator(int a, int b)
// {
//     if(a == b)
//     {
//         return a;
//     }
//     else if(a < b)
//     {
//     return (a + Summator(++a, b));
//     }
//     return a;
// }

// 3 вариант решения (Цикл for)

// int num1 = new Random().Next(1, 5);
// int num2 = new Random().Next(5, 11);
// int res = 0;
// Console.WriteLine($"num1 = {num1}, num2 = {num2}");

// Summator(num1, num2);

// void Summator(int a, int b)
// {
//     res += a;
//     for (int i = num1; num1 < num2; i++)
//     {
//         Summator(++num1, num2);
//     }
// }
// Console.WriteLine(res);

//***********************************************************************************************************************

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

// int n = 2;
// int m = 3;

// Akherman(n, m);

// Console.WriteLine(Akherman(n, m));

// int Akherman(int n, int m)
// {
//     if (n == 0)
//     {
//         return ++m;
//     }
//     else if (m == 0)
//     {
//         return Akherman(n - 1, 1);
//     }
//     else
//     {
//         return Akherman(n - 1, Akherman(n, m - 1));
//     }
// }