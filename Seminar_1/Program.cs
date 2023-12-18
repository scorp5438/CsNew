// Задача №1

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень числа: ");
// int x = Convert.ToInt32(Console.ReadLine());

// double result = Math.Pow(number, x);
// // number *= number;

// // Console.WriteLine(number);
// Console.WriteLine(number + " в степени " + x + " = " + result);


// Задача №2

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2 * num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// Задача №3

// Console.WriteLine("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num1 == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(num1 == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(num1 == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if(num1 == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(num1 == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(num1 == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(num1 == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня нет");
// }


// Задача №4

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0)
{
    int neGnum = -1 * num; // num = -5 neGnum = 5
    while(num <= neGnum)
    {
    Console.Write(neGnum + " ");
    neGnum -= 1;
    }
}
else
    {
     int neGnum = -num;
     while(neGnum <= num)
    {
    Console.Write(neGnum + " ");
    neGnum += 1;
    }
}


// Задача №5

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num < 100)
// {
//     Console.Write("Введите другое число");
// }
// else if (num > 999)
// {
//     Console.Write("Введите другое число");
// }
// else
// {
//     int result = num % 10;
//     Console.Write(result);  
// }
