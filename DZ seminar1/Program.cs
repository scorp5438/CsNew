// ДЗ№1

// Console.WriteLine("Введите первое число: ");
// int firstnum = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Второе число: ");
// int secondnum = Convert.ToInt32(Console.ReadLine());

// if (firstnum > secondnum)
// {
//     Console.WriteLine("Число " +  firstnum + " больше чем число " + secondnum);
// }
// else
// {
//     Console.WriteLine("Число " +  secondnum + " больше чем число " + firstnum);
// }


// // ДЗ№2

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a > b)
//     {   
//     if (a > c)
//         {
//             Console.WriteLine(a);
//         }
//     else
//         {
//             Console.WriteLine(c);
//         }
//     }
// else
//     {
//     if(b > c)
//         {
//             Console.WriteLine(b);
//         }   
//     else
//         {
//             Console.WriteLine(c);
//         } 
// }
// else if ((firstnum == secondnum) & (secondnum == thirdnum))
// {
//     Console.WriteLine("Все числа равны");
// }


// ДЗ№3

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 0)
// {
//     Console.WriteLine("Вы ввели 0 ");
// }
// else
// {
//     if (number % 2 == 0)
//     {
//         Console.WriteLine($"Число `{number}` чётное");
//     }
//     else
//     {
//         Console.WriteLine("Число `" + number + "` нечётное");
//     } 
// }


// ДЗ№4

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number <= 0)
// {
//     Console.WriteLine("Вы ввели число меньше или равно 0 ");
// }
// else
// {
//     int count = 2;
//     while (count <= number)
//     {
//         Console.Write(count + "  ");
//         count += 2;
//     }
// }


// int a = 5, b = 6, c = 7;

// int max = a;

// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }

// Console.Write(max);


// int old = 254;
// string name = "SofiA";
// // string hobby = "TV";

// // Console.WriteLine("Имя: " + name + " возраст: " + old + " увлечение: " + hobby);

// // Console.WriteLine("Имя: " + name );
// // Console.WriteLine("Возраст: " + old);
// // Console.WriteLine("Увлечение: " + hobby);

// // Console.WriteLine($"\nИмя: {{\"{name}\"}}\nВозраст: {old}\nУвлечение: {hobby}");

// char[] rev = name.Reverse().ToArray();

// // Console.WriteLine(name == rev.ToString());
// Console.WriteLine(name == string.Concat<char>(rev));
// Console.WriteLine();