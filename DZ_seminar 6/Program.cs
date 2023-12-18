// Задача 1 упрощенная

// int count = new Random().Next(5, 11);
// Console.WriteLine($"Введите {count} чисел");
// int res = 0;

// while (count-- > 0)
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 0) res++;
// }
// Console.WriteLine($"\nЧиcел больше 0: {res}");

// Задача 1 усложненная

// Console.WriteLine("Введите число или \"н\" для выхода");
// int res = 0;
// bool isNum = true;

// while (isNum)
// {
//     string num = Console.ReadLine();
//     isNum = int.TryParse(num, out int number);
//     if (isNum)
//     {
//         if (number > 0) res++;
//     }
//     else if(num.ToLower() == "н")
//     {
//         isNum = false;
//     }
//     else
//     {
//         Console.WriteLine("Введена некорректная команда.\nВводите число или \"н\" для выхода");
//         isNum = true;
//     }
// }
// Console.WriteLine($"\nЧиcел больше 0: {res}");

// Задача 2

// double b1 = 2;
// double k1 = 5;
// double b2 = 4;
// double k2 = 9;

// void findX(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1)/(k1 - k2);
//     findY(x, k1, b1);
// }

// void findY(double x, double k1, double b1)
// {
//     double y = k1 * x + b1;
//     Console.WriteLine($"x = {x}\ny = {y}");
// }

// findX(b1, k1, b2, k2);