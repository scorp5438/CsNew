/*
Задача 1
Задайте число N.
Напишите прошрумиму, которая выведет
все натуральные числа в промежутке от 1 до N
*/

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int startNum = 1;
// Console.WriteLine(PrintNumbers(startNum, num));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

//*****************************************************************************************************
/*
Задача 2
Задайте значение M и N.
Напишите программу, которая выведет
все натуральные числа в промежутке от M до N
*/

// Console.WriteLine("Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine(PrintNumbers(num2, num1));
// }
// else if (num1 < num2)
// {
//     Console.WriteLine(PrintNumbers(num1, num2));
// }
// else
// {
//     Console.WriteLine("Числа равны");
// }

// string PrintNumbers(int start, int end)
// {

//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

//*****************************************************************************************************
/*
Задача 3
Задайте значение M и N.
Напишите прошрумиму, которая будет принимать число и возвращать сумму его чисел
*/

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintNumbers(num));

// int PrintNumbers(int num)
// {
//     num = num % 10 + num/10;
//     if (num < 10) return num;
//     return (num % 10 + PrintNumbers(num / 10));
// }

//*****************************************************************************************************

/*
Задача 4
Напишите прошрумиму, которая будет принимать два числа A и И 
и возводить первое число в степень второго с помощью рекурсии
*/

// Console.WriteLine("Введите первое число:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Pow(num, num1));

// int Pow(int numm, int rank)
// {
//     if (rank == 0) return 1;
//     if (rank == 1) return num;

//     return (numm * Pow(num, --rank));
// }

//*****************************************************************************************************