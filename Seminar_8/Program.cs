// Задача 1

// Console.WriteLine("Укажите количество строк: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите количество столбцов: ");
// int row = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [col, row];

// void CreateArray(int [,] collections, int col, int row)
// {
//     for (int i = 0; i < collections.GetLength(0); i++)
//     {
//         for (int j = 0; j < collections.GetLength(1); j++)
//         {
//             int number = new Random().Next(10);
//             collections[i, j] = number;
//         }
//     }
// }

// void ChangeString(int [,] collections)
// {
//     int rowCount = array.GetLength(0) - 1;

//     for (int i = 0; i < collections.GetLength(1); i++)
//     {
//         int temp = array[0, i];
//         array[0, i] = array[rowCount, i];
//         array[rowCount, i] = temp;
//     }
// }

// void PrintArray(int [,] collections)
// {
//     for (int i = 0; i < collections.GetLength(0); i++)
//     {
//         for (int j = 0; j < collections.GetLength(1); j++)
//         {
//             Console.Write($"{collections[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// CreateArray(array, col, row);
// PrintArray(array);
// ChangeString(array);
// Console.WriteLine();
// PrintArray(array);

// **********************************************************************************
// Задача 2

// Console.WriteLine("Укажите размер массива: ");
// int col = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [col, col];

// CreateArray(array);

// void CreateArray(int [,] collections)
// {
//     for (int i = 0; i < collections.GetLength(0); i++)
//     {
//         for (int j = 0; j < collections.GetLength(1); j++)
//         {
//             int number = new Random().Next(10);
//             collections[i, j] = number;
//         }
//     }
// }

// int[,] ChangeString(int [,] collections)
// {
//     int [,] temparray = new int[col, col];

//     for (int i = 0; i < collections.GetLength(0); i++)
//     {
//         for (int j = 0; j < collections.GetLength(1); j++)
//         {
//             temparray[j, i] = array[i, j];
//         }
//     }
//     return temparray;
// }

// void PrintArray(int [,] collections)
// {
//     for (int i = 0; i < collections.GetLength(0); i++)
//     {
//         for (int j = 0; j < collections.GetLength(1); j++)
//         {
//             Console.Write($"{collections[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// CreateArray(array);
// PrintArray(array);
// ChangeString(array);
// Console.WriteLine();
// PrintArray(ChangeString(array));

// **********************************************************************************
// Задача 3

// Console.WriteLine("Укажите размер массива: ");
// int col = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [col, col];
// int minElement = 10;
// int minRows = 0;
// int minColumn = 0;

// void CreateArray(int [,] collections)
// {
//     for (int i = 0; i < collections.GetLength(0); i++)
//     {
//         for (int j = 0; j < collections.GetLength(1); j++)
//         {
//             int number = new Random().Next(10);
//             collections[i, j] = number;
//             if (collections[i, j] < minElement)
//             {
//                 minElement = collections[i, j];
//                 minRows = i;
//                 minColumn = j;
//             }
//         }
//     }
// }

// void ChangeString(int [,] collections)
// {
//     for (int i = 0; i < collections.GetLength(0); i++)
//     {
//         for (int j = 0; j < collections.GetLength(1); j++)
//         {
//             if (i!= minRows && j!= minColumn)
//             {
//                 Console.Write($"{collections[i, j]} ");
//             }
//         }
//          Console.WriteLine();
//     }
// }

// void PrintArray(int [,] collections)
// {
//     for (int i = 0; i < collections.GetLength(0); i++)
//     {
//         for (int j = 0; j < collections.GetLength(1); j++)
//         {
//             Console.Write($"{collections[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// CreateArray(array);

// PrintArray(array);
// ChangeString(array);
// Console.WriteLine();
// Console.WriteLine($"minRows = {minRows} minColumn = {minColumn}");
