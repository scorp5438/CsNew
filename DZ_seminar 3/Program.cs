// Задача 1

// int number = 23532;

// char[] rev = number.ToString().Reverse().ToArray();

// Console.WriteLine(number.ToString().Length == 5 && number.ToString() == string.Concat(rev));
// Console.WriteLine(number.ToString().Length == 5 && number.ToString() == new string(rev));


// // Задача 1 вариант решения 2

// int number = 235321;

// string str = number.ToString();

// if(str.Length != 5)
// {
//     Console.WriteLine($"Число не пятизначное\n{str.Length == 5}");
// }
// else
// {
//     Console.WriteLine(str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]);
// }

// Задача 2


// int[] arr1 = {3, 6, 8};
// int[] arr2 = {2, 1, -7};

// double res= Math.Pow((Math.Pow((arr1[0] - arr2[0]), 2) + Math.Pow((arr1[1] - arr2[1]), 2) + Math.Pow((arr1[2] - arr2[2]), 2)), 0.5);
// Console.WriteLine(res);


// Задача 3

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// for(int i = 1; i <= num; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }

