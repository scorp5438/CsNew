// Задача 1

// int rows = new Random().Next(5,21);
// Console.Write("Введите число: ");

// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows, columns];

// CreateArray(array);
// PrintArray(array);

// void CreateArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int number = new Random().Next(10);
//             array[i, j] = number;
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 2
//*******************************************************************************************

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows, columns];

// CreateArray(array);
// PrintArray(array);

// void CreateArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int number = i + j;
//             array[i, j] = number;
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 2
//*******************************************************************************************

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows, columns];

// CreateArray(array);
// PrintArray(array);
// RedactArray(array);
// PrintArray(array);

// void CreateArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int number = new Random().Next(10);;
//             array[i, j] = number;
//         }
//     }
// }

// void RedactArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 array[i, j] = array[i, j] * array[i, j];
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Задача 2
//*******************************************************************************************

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows, columns];
// int res = 0;

// CreateArray(array);
// PrintArray(array);
// FindSumArray(array);
// Console.WriteLine($"Сумма главной диагонали = {res}");

// void CreateArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int number = new Random().Next(10);;
//             array[i, j] = number;
//         }
//     }
// }

// void FindSumArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 res += array[i, j];
//             }
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
