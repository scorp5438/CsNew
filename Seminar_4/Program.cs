// Возвращающее значение (тип) Название + (параметры) {Тело функции}

// int number = new Random().Next(5, 11);
// Console.WriteLine(number);

// int GetSum(int num)
// {
//     int start = 1;
//     int sum = 0;
//     while(start <= num)
//     {
//         sum  += start;
//         start++;
//     }
//     return sum;
// }

// int res = GetSum(number);
// Console.WriteLine(res);

//******************************************************************************

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(GetCount(num));

// int GetCount(int n)
// {
//     int res = 0;
//     if(n == 0) res = 1;
//     while(n > 0)
//     {
//         n /= 10;
//         res++;
//     }
//     return res;
// }


//******************************************************************************

// int number = new Random().Next(2, 11);

// Console.WriteLine(number);

// int Mult(int num)
// {
//     int start = 1;
//     int multiplication = 1;
//     while(start <= num)
//     {
//         multiplication  *= start;
//         start++;
//     }
//     return multiplication;
// }

// int res = Mult(number);
// Console.WriteLine(res);


//******************************************************************************

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] arr = new int[8];
CreateArray(arr);
void CreateArray(int[] array)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(2);
        Console.Write(arr[i] + " ");
    }
}