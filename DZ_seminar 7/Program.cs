// Задача 1

// int m = new Random().Next(3, 10);
// int n = new Random().Next(3, 10);

// int minLimitRandom = -10;
// int maxLimitRandom = 20;

// double [,] array = new double [m, n];

// CreateArray(m, n, minLimitRandom, maxLimitRandom);
// PrintArray(array);

// void CreateArray(int m, int n, int minLimitRandom, int maxLimitRandom)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Random rnd =  new Random();
//             double number = (rnd.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom);
//             array[i, j] = number;
//         }
//     }
// }

// void PrintArray(double[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]:f2}\t");
//         }
//         Console.WriteLine();
//     }
// }

//*******************************************************************************

// Задача 2

// int m = 4;
// int n = 5;
// int k = 3;
// int x = 4;
// int y = 5;

// CreateArray(n, m, k);

// int[,] CreateArray(int n, int m, int k)
// {
//     int num = 1;
//     int [,] array = new int [n, m];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = num;
//             num += k;
//         }
//     }
//     PrintArray(array);
//     PrintCheckIfError(FindNumber(array, x, y), x, y);
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int [] FindNumber(int [,] matrix, int rowPosition, int columnPosition)
// {
//     int[] result = new int[2];
//     if (rowPosition - 1 < matrix.GetLength(0) && columnPosition - 1 < matrix.GetLength(1))
//     {
//         result[0] = matrix[rowPosition, columnPosition];
//         result[1] = 0;
//     }
//     else
//     {
//         result[0] = 0;
//         result[1] = 0;
//     }
//     return result;
// }

// void PrintCheckIfError (int[] result, int x, int y)
// {
//     if (result[0] == 0)
//     {
//         Console.WriteLine($"There is no such index");
//     }
//     else
//     {
//         Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");
//     }
// }

//*******************************************************************************

// Задача 3

// int n = 4;
// int m = 5;
// int k = 3;

// PrintArray(CreateArray(n, m, k));
// PrintListAvr(FindAverageInColumns(CreateArray(n, m, k)));

// int[,] CreateArray(int n, int m, int k)
// {
//     int num = 1;
//     int [,] array = new int [n, m];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = num;
//             num += k;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// double [] FindAverageInColumns (int [,] matrix)
// {
//     double [] result = new double[matrix.GetLength(1)];
//     double temp = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             temp += matrix[j, i];
//         }
//         result[i] = temp / matrix.GetLength(0);
//         temp = 0;
//     }
//     return result;
// }

// void PrintListAvr (double [] list)
// {
//     Console.WriteLine("The averages in columns are:");
//     for (int i = 0; i < list.Length; i++)
//     {
//         Console.Write($"{list[i]:f2}\t");
//     }
// }
