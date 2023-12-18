// // Задача 1

// int EnterNumber(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int Square(int a, int b)
// {
//     int count = 1; 
//     int res = 1;
//     while(count <= b)
//     {
//         res *= a;
//         count++;
//     }
//     return res;
// }
// int a = EnterNumber("Введите число: ");
// int b = EnterNumber("Введите степень: ");
// Console.WriteLine(Square(a, b));


// // Задача 2

// int num = new Random().Next(100, 999999);
// Console.WriteLine(num);

// int SumRec(int number)
// {   
//     int start = 0;
//     int res = 0;
//     while (number > start)
//     {
//         res += number % 10;
//         number /= 10;
//     }
//     return res;
// }

// Console.WriteLine(SumRec(num));


// // Задача 2 усложненный вариант версия 1

// int num = new Random().Next(100, 999999);
// Console.WriteLine(num);

// int SumRec(int number)
// {   
//     int start = 0;
//     int res = 0;
//     while (number > start)
//     {
//         res += number % 10;
//         number /= 10;
//     }
//     if(res < 10) return res;
//     return SumRec(res);
// }

// Console.WriteLine(SumRec(num));


// // Задача 2 усложненный вариант версия 2

// int num = new Random().Next(100, 999999);
// int num = 583741;
// Console.WriteLine(num);

// int SumRec(int number)
// {   
//     int start = 0;
//     int res = 0;
//     while (number > start)
//     {
//         {
//             res += number % 10;
//             number /= 10;
//         }
//         while(res > 9)
//         {
//             int temp = res;
//             res = 0;
//             while(temp > start)
//             {
//                 res += temp % 10;
//                 temp /= 10;
//             }
//         }
//     }
//     return res;
// }
// Console.WriteLine(SumRec(num));


// Задача 3

// // int length = new Random().Next(7, 11);
// // int min = new Random().Next(-10, -5);
// // int max = new Random().Next(5, 11);

// int EnterNumber(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// void CreateArray(int length, int min, int max)
// {
//     int[] arr = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = new Random().Next(min, max);
//     }
//     PrintArray(arr);
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int length = EnterNumber("Введите длину массива: ");
// int min = EnterNumber("Введите минимальное число массива: ");
// int max = EnterNumber("Введите максимальное число массива: ");
// CreateArray(length, min, max);
