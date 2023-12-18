// Задача 1

// int x = new Random().Next(-15, 15);
// int y = new Random().Next(-15, 15);
// Console.WriteLine($"x = {x}  y = {y}");
// if (x > 0 && y > 0)
// {
//     Console.WriteLine(1);
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine(4);
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine(2);
// }
// else
// {
//     Console.WriteLine(3);
// }


// Задача 2

// int num = new Random().Next(6);
// Console.WriteLine($"{num}");

// switch(num) // Аналог if
// {
//     case 1:
//     {
//         Console.WriteLine("X>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("X<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("X<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("X>0 y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Такой четверти нет");
//         break;
//     }
// }


// Задача 3

// Console.WriteLine("Введите число: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// // double res = Math.Sqrt(50); // Корень из числа
// // Math.Pow(5, 2) // Возведение числа в степень

// double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

// Console.WriteLine(res);

// Задача 4

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// for(int i = 1; i <= num; i++)
// {
//     Console.WriteLine(Math.Pow(i, 2));
// }