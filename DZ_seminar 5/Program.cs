// // Задача 1

// int[] array = { 100, 102, 105, 166, 283, 764, 300, 499, 133 };

// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
//     Console.Write($"{array[i]}\t");
// }
// Console.Write($"\nКоличество четных элементов: {count}");

// Задача 2

// int[] array =  { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };

// int res = 0;
// for(int i = 0; i < array.Length; i ++)
// {
//     if(i % 2 == 1)
//     {
//         res += array[i];
//     }
//     Console.Write($"{array[i]}\t");
// }
// Console.WriteLine($"\n{res}");

// Задача 3

// double[] array = { 3.17, 8.94, 2.36, 5.72, 0.85 };


// double FindMax(double[] array)
// {
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//     }
//     return max;
// }

// double FindMin(double[] array)
// {
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//     }
//     return min;
// }

// double CalcDifferenceBetweenMaxMin(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//         else if (array[i] > max) max = array[i];
//     }
//     double res = max - min;
//     return res;
// }
// void PrintArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i ++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// FindMax(array);
// FindMin(array);
// double res = CalcDifferenceBetweenMaxMin(array);
// Console.WriteLine("Массив: ");
// PrintArray(array);
// Console.WriteLine($"\nРазность между максимальным и минимальным элементом = {res:f2}");
