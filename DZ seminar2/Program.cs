// // Задача 1

// int num = new Random().Next(100, 999);
// Console.WriteLine(num);

// int result = num / 10 % 10;
// Console.WriteLine(result);


// Задача 1 2 вариант решения

// int num = new Random().Next(100, 999);
// Console.WriteLine(num);

// string str = Convert.ToString(num);


// int result = Convert.ToInt32(Convert.ToString(str[1]));
// Console.WriteLine(result);

// // Задача 2

// int num = new Random().Next(0, 2000);
// Console.WriteLine(num);
// if(num < 100)
// {
//     Console.WriteLine("Tретьей цифры нет");
// }
// else
// {   
//     while (num > 999)
//     {
//         num /= 10;
//     }
//     num %= 10;
//     Console.WriteLine(num);
// }

// Задача 2 2 вариант решения

// int num = new Random().Next(0, 2000);
// Console.WriteLine(num);

// if(num < 100)
// {
//     Console.WriteLine("Tретьей цифры нет");
// }
// else
// {
//     string str = num.ToString();
//     int result = Convert.ToInt32(str[2].ToString());
//     Console.WriteLine(result);
// }


// Задача 3

// int num = new Random().Next(14);
// Console.WriteLine(num);

// if(num == 6 || num == 7)
// {
//     Console.WriteLine("Урааа выходной!!!");
// }
// else if(num > 0 && num < 6)
// {
//     Console.WriteLine("Поработаем еще");
// }
// else
// {
//     Console.WriteLine("Это не день недели");
// }

// Задача 3 2 вариант решения

int num = new Random().Next(14);
Console.WriteLine(num);
var Week = new Dictionary<int, string>()
{
    {1, "Понедельник"},
    {2, "Вторник"},
    {3, "Среда"},
    {4, "Четверг"},
    {5, "Пятница"},
    {6, "Субботу"},
    {7, "Воскресенье"},
};

bool day = Week.ContainsKey(num);
if (day)
{
    if(Week[num] == "Субботу" || Week[num] == "Воскресенье")
    {
        Console.WriteLine("Урааа выходной!!!");
    }
    else
    {
        Console.WriteLine("Поработаем еще");
    }
}
else
{
    Console.WriteLine("Это не день недели");
}
