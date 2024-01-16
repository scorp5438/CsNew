
// Задача 1 
// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int size = new Random().Next(5, 10);
int [,] collections = new int [size, size];

CreateArray(collections);
ShowArray(collections);
SortedArrayTwo(collections);
Console.WriteLine();
ShowArray(collections);

void CreateArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0 + i; j < arr.GetLength(1); j++)
        {
            int num = new Random().Next(5, 10);
            arr[i, j] = num;
            arr[j, i] = num;
        };
    }
}

void ShowArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");

        }
        Console.WriteLine();
    }
}

void SortedArrayTwo (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {    
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, max]) max = k;
            }
            int temp = arr[i, j];
            arr[i, j] = arr[i, max];
            arr[i, max] = temp;
        }
    }
}

//**************************************************************************************************************************

// Задача 2
//: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

// int size = new Random().Next(5, 10);

// int [,] collections = new int [3, 3];

// CreateArray(collections);
// ShowArray(collections);

// int res = SumOfRow(collections, MinimumSumRow(collections)[0]);

// Console.WriteLine(res);

// void CreateArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 6);
//         };
//     }
// }

// int [] MinimumSumRow (int[,] matrix)
// {
//     int summ = int.MaxValue;
//     int temp = 0;
//     int [] sum = new int [2];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp += matrix[i, j];
//         }
//         if (temp < summ)
//         {
//             summ = temp;
//             sum[0] = i;
//             sum[1] = summ;
//         }
//         temp = 0;
//     }
//     return sum;
// }

// int SumOfRow (int [,] matrix, int row)
// {
//     int sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sum += matrix[row, j];
//     }
//     return sum;
// }

// void ShowArray (int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}  ");

//         }
//         Console.WriteLine();
//     }
// }

//**************************************************************************************************************************

// Задача 3
// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

// int [,] matrixA = 
// {
//     {1, 2, 3},
//     {1, 2, 3},
//     {1, 2, 3},
//     {1, 2, 3}
// };

// int [,] matrixB = 
// {
//     {4, 3, 2, 1},
//     {4, 3, 2, 1},
//     {4, 3, 2, 1}
// };

// MultiplyIfPossible(matrixA,matrixB);

// void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
// {
//     if (matrixA.GetLength(1) == matrixB.GetLength(0))
//     {
//         MatrixMultiplication(matrixA, matrixB);
//     }
//     else if (matrixA.GetLength(1) != matrixB.GetLength(0))
//     {
//         Console.WriteLine("It is impossible to multiply.");
//     }

// }

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {  // Введите свое решение ниже
//     int[,] ResMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < ResMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ResMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 ResMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//         }
//     }
//     PrintMatrix(ResMatrix);
//     return ResMatrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//     }
// }


// i  j  k      i  k     k  j
// 0, 0, 0      0, 0  *  0, 0
// 0, 0, 1      0, 1  *  1, 0

// 0, 1, 0      0, 0  *  0, 1
// 0, 1, 1      0, 1  *  1, 1

// 0, 2, 0      0, 0  *  0, 2
// 0, 2, 1      0, 1  *  1, 2
//***************************
// 1, 0, 0      1, 0  *  0, 0
// 1, 0, 1      1, 1  *  1, 0

// 1, 1, 0      1, 0  *  0, 1
// 1, 1, 1      1, 1, *  1, 1

// 1, 2, 0      1, 0  *  0, 2
// 1, 2, 1      1, 1  *  1, 2
//***************************
// 2, 0, 0      2, 0  *  0, 0
// 2, 0, 1      2, 1  *  1, 0

// 2, 1, 0      2, 0  *  0, 1
// 2, 1, 1      2, 1  *  1, 1

// 2, 2, 0      2, 0  *  0, 2
// 2, 2, 1      2, 1  *  1, 2

//**************************************************************************************************************************

// Задача 5
// Сформируйте трёхмерный массив из неповторяющихся
//  двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

// int [,,] array =new int [4, 4, 4];

// string line = "_";
// Creat3DArray();
// ArrayPrint(array, line);

// void Creat3DArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 int number = new Random().Next(10, 100);
//                 bool thereIs = true;
//                 foreach (int x in array)
//                 {
//                     if (x == number)
//                     {
//                         thereIs = false;
//                     }
//                 }
//                 if (thereIs)
//                 {
//                     array[i, j, k] = number;
//                 }
//                 else k--;
//             }
//         }
//     }
// }

// void ArrayPrint(int [,,] array,string line)
// {
//     for(int i = 0; i < 24 * array.GetLength(2) - 5; i++)
//     {
//         line += "_";
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 // Console.Write($"{array[i, j, k]}\t");
//                 Console.Write($"|array({i}, {j}, {k}) - {array[i, j, k]}|\t");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine(line);
//     }
// }

//**************************************************************************************************************************

// Задача 5
// Заполните спирально массив 4 на 4

// int m = new Random().Next(3,15);
// int n = new Random().Next(3,15);

// int [,] array = new int [15, 17];
// int row = array.GetLength(0);
// int column = array.GetLength(1);
// int num = 1;

// RingCreate(array, column, row);
// PrintArray(array);

// void RingCreate (int[,] array, int col, int row, int x = 0, int y = 0)
// {
//     for (int j = y; j < col; j++)
//     {
//         if (array[x, j] == 0)
//         {
//             array[x, j] = num;
//             num++;
//         }
//         y++;
//     }
//     y--;
//     for (int i = x; i < row; i++)
//     {
//         if (array[i, y] == 0)
//         {
//             array[i, y] = num;
//             num++;
//         }
//         x++;
//     }
//     x--;
//     for (int j = y; j >= array.GetLength(0) - row; j--)
//     {
//         if (array[x, j] == 0)
//         {
//             array[x, j] = num;
//             num++;
//         }
//         y--;
//     }
//     y++;
//     for (int i = x; i >= array.GetLength(1) - col; i--)
//     {
//         if (array[i, y] == 0)
//         {
//             array[i, y] = num;
//             num++;
//         }
//         x--;
//     }
//     x++; 
//     while(array[array.GetLength(0)/2, array.GetLength(1)/2] == 0)
//     {
//         RingCreate(array, col-1, row-1, x+1, y+1);
//     }
// }

// void PrintArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }