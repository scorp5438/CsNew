// Задача 1

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num3)
//     Console.WriteLine("Может");
// else
//     Console.WriteLine("Не может");

// ****************************************************************************

// Задача 2

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string binary = Convert.ToString(num, 2);
// Console.WriteLine(binary);

// string result = String.Empty;

// while (num > 0)
// {
//     result = num%2 + result;
//     num /= 2;
// }
// Console.WriteLine(result);

// ****************************************************************************

// Задача 3

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 0, secondNum = 1;

// if (num == 1) Console.WriteLine(firstNum);
// else if (num < 1) Console.WriteLine("Nothing");
// else
// {
//     Console.Write(firstNum + " " + secondNum + " ");

//     for (int i = 3; i <= num; i++)
//     {
//         int NextNum = firstNum + secondNum;
//         Console.Write(NextNum + " ");
//         firstNum = secondNum;
//         secondNum = NextNum;
//     }
// }

// Задача 3 вариант 2

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int a = 0, b = 1;

// Console.Write($"{a} {b} ");

// for (int i = 3; i <= num; i++)
// {
//     a = a + b;
//     b += a;
//     Console.Write($"{a} {b} ");
// }


// ****************************************************************************

// Задача 4

// int [] array = new int[]{4, 1, 92, 5, 15};
// int [] array2 = new int[array.Length];

// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = array[i];
//     Console.Write(array2[i] + " ");
// }

// ****************************************************************************

// Задача 5

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];

// void createArray(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         int elem = new Random().Next(0, 10);
//         a[i] = elem;
//     }
//     printArray(a);
// }

// void reverseArr(int [] x)
// {
//     for (int j = 0; j < x.Length / 2; j++)
//     {
//         int temp = x[j];
//         x[j] = x[x.Length - 1 - j];
//         x[x.Length - 1 - j] = temp;
//     }
//     printArray(array);
// }

// void printArray(int[] ar)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// createArray(array);

// reverseArr(array);


// Robots R2D2 = new Robots();
// Robots C3PO = new Robots();

// C3PO.life = 400;
// Console.WriteLine(R2D2.life);
// R2D2.damages(C3PO.damage);
// Console.WriteLine(R2D2.life);

// class Robots
// {
//     public int life = 500;
//     public int damage = 100;
//     public void damages(int damage)
//     {
//         life -= damage;
//     }
// }
