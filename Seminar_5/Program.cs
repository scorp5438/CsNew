// Задача 1

// int[] arr = new int[12];

// void CreateArray(int[] array)
// {
//     int sumPosNum = 0;
//     int sumNegNum = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);
//         Console.Write(arr[i] + " ");
//         if(arr[i] > 0)
//         {
//             sumPosNum += arr[i];
//         }
//         else
//         {
//             sumNegNum += arr[i];
//         }
//     }
// }
// CreateArray(arr);

// Console.WriteLine($"\nСумма положительных: {sumPosNum}\nСумма отрицательных: {sumNegNum}");

// ********************************************************************************************

// Задача 2

// int[] arr = {-4, -8, 8, 2, -12};
// for(int i = 0; i < arr.Length; i++)
// {
//     arr[i] *= -1;
//     System.Console.Write(arr[i] + " ");
// }

// ********************************************************************************************

// Задача 3

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[12];
// bool IsFind = false;
// void CreateArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//         Console.Write($"{array[i]} ");

//         if(array[i] == num)
//         {
//             IsFind = true;
//         }
//     }
//     if(IsFind)
//     {
//         Console.Write($"\nДа");
//     }
//     else
//     {
//         Console.Write($"\nНет");
//     }
// }
// CreateArray(arr);

// ********************************************************************************************

// Задача 4

// int count = 0;
// int[] arr = new int[123];
// void CreateArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 300);
//         Console.Write($"{array[i]} ");

//         if(arr[i] > 9 && arr[i] < 100)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine($"\nКол-во = {count}");
// }
// CreateArray(arr);

// ********************************************************************************************

// Задача 5

// int n = new Random().Next(5, 12);
// int[] arr = new int[n];
// int[] arr2 = new int[arr.Length / 2 + arr.Length % 2];

// void CreateArray()
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     for(int i = 0; i < arr2.Length; i++)
//     {
//         arr2[i] = arr[i] *arr[arr.Length -1 - i];
//         if (i == arr.Length - 1 - i)
//         {
//             arr2[i] = arr[i];
//         }
//         Console.Write($"{arr2[i]} ");
//     } 
// }
// CreateArray();

