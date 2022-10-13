//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3



//  Console.Write("Введите первое число ");

//  int num1 = Convert.ToInt32(Console.ReadLine());

//  Console.Write("Введите второе число ");

//  int num2 = Convert.ToInt32(Console.ReadLine());

//  if (num1 > num2)
//  {
//      Console.WriteLine(num1 + " Это большее число");
//      Console.WriteLine(num2 + " Это меньшее число");
//  }
//  else
//  {
//      Console.WriteLine(num2 + " Это большее число");
//      Console.WriteLine(num1 + " Это меньшее число");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число ");

// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число ");

// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число ");

// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 >= num2)
// {
//     if (num1 >= num3)
//     Console.WriteLine(num1 + " Это большее число");
// }
// if (num2 > num3)
// {
//     if (num2 >= num1)
//     Console.WriteLine(num2 + " Это большее число");
// }
// if (num3 >= num2)
// {
//     if (num3 >= num1)
//     Console.WriteLine(num3 + " Это большее число");
// }
    

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число : ");

// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 ==0)
//  {
//      Console.WriteLine ("Четное");
//  }
//  else Console.WriteLine ("Нечетное");

//  Console.WriteLine((int.Parse(Console.ReadLine()) & 1) == 0? "Yes": "No");  // Второй Вариант



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число: ");

// int n = Convert.ToInt32(Console.ReadLine());

// int i = 2;

// while (i < n+1)
// {
//     Console.Write(i++ + " ");  
//     i++;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 22;
// int c3 = 33;

// int max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// Console.WriteLine(max);

// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int x = new Random().Next(10,99);

// int a = x / 10;
// int b = x % 10;
// Console.WriteLine(x);
// if(a > b)
// {
//     Console.WriteLine(a + " Больше");
// }
// else if (a < b)
// {
//     Console.WriteLine(b + " Больше");
// }
// else
// {
//     Console.WriteLine("Они равны");
// }


// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int x = new Random().Next(100,1000);
// Console.WriteLine(x);

// int a = x / 100;
// int b = x % 10;

// Console.Write(a);
// Console.WriteLine(b);       // ПОЧЕМУ МЫ КОГДА МЫ ДЕЛИМ ЧИСЛО НА 100 ПОЛУЧАЕТСЯ ЖЕ ДВУХЗНАЧНОЕ ЧИСЛО

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int a = num1 % 7;
// int b = num1 % 23;
// if (a == 0 & b == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите 1 число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите 2 число");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a == b*b || b == a*a)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());

// int a = x % 100;
// int b = a / 10;

// Console.Write(b);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());

// string xa = Convert.ToString(x);

// if (xa.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + xa[2]);
// }
// else 
// {
//   Console.WriteLine("-> третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число от 1 до 7");
// int x = Convert.ToInt32(Console.ReadLine());

// if ( x > 5)  
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     Console.WriteLine("Рабочий");
// }


// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.




// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x == 1) Console.WriteLine("x > 0, y > 0");
// else if (x == 2) Console.WriteLine("x < 0, y > 0");
// else if (x == 3) Console.WriteLine("x < 0, y < 0");
// else if (x == 4) Console.WriteLine("x > 0, y < 0");
// else Console.WriteLine("Такой четверти нет");


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координаты х точки А");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты у точки А");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты х точки В");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты у точки В");
// int b2 = Convert.ToInt32(Console.ReadLine());

// double ab = Math.Sqrt(Math.Pow((a2-a1), 2) + Math.Pow((b2-b1), 2));

// Console.WriteLine($" Расстояние между точками А и В = {ab}");

// Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());

// int i = 0;
// while (i < x)
// {
//     Console.Write($"{Math.Pow(i, 2)} "); i++;
// }


// 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");


// string number = Console.ReadLine();

// if (number.Length != 5)
// {
//     Console.WriteLine("Введите правильное число");
// }
//     if (number[0] == number[4] & number[1] == number[3])
// {
//     Console.WriteLine($"Ваше число {number} палиндроп.");
// }
//     else Console.WriteLine($"Ваше число {number} - НЕ палиндром.");


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты х точки А");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты у точки А");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки А");
// int a3 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите координаты х точки В");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты у точки В");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки B");
// int b3 = Convert.ToInt32(Console.ReadLine());

// // √((x2-x1)^2 )+(y2-y1)^2+(z2-z1)^2

// double ab = Math.Sqrt(Math.Pow((a1-b1), 2) + Math.Pow((a2-b2), 2) + Math.Pow((a3-b3), 2));

// Console.WriteLine($" Расстояние между точками = {ab}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());

// int i = 1;

// while (i < x+1)
// {
//     Console.Write($"{Math.Pow(i, 3)} "); i++;
// }


// 1 
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());

// int i = 0;
// int sum = 0;

// for (i = 0; i <= x; i++)
// {
//     sum = sum + i;
    
// }

// Console.WriteLine(sum);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число ");
// string x = Console.ReadLine();

// int a = Convert.ToInt32(x);

// int q = x.Length;

// Console.Write(q);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());

// int i = 0;
// int sum = 1;

// for (i = 1; i <= x; i++)
// {
//     sum = sum * i;
    
// }

// Console.WriteLine(sum);



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int n = 8;
// int[] arr = new int[n];
// Random rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(0,2);
// }
// Console.WriteLine(string.Join(", ", arr));


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] random(int start, int  end, int LengthArr)
// {
//     int[] arr = new int[LengthArr];
//     for (int i = 0; i < LengthArr; i++)
//     {
//         arr[i] = new Random().Next(start, end + 1);
//     }
//     return arr;
// }

// int[] arr = random(-9, 9, 12);
// int SumPlus = 0;
// int SumMinus = 0;

// for(int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < 0)
//     {
//         SumMinus += arr[i];
//     }
//     else
//     {
//         SumPlus += arr[i];
//     }
//     Console.Write($"{arr[i]}, ");
// }
// Console.WriteLine();
// Console.WriteLine(SumMinus);
// Console.WriteLine(SumPlus);



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] random(int start, int  end, int LengthArr)
// {
//     int[] arr = new int[LengthArr];
//     for (int i = 0; i < LengthArr; i++)
//     {
//         arr[i] = new Random().Next(start, end + 1);
//     }
//     return arr;
// }

// int[] arr = random(-9, 9, 12);
// int SumPlus = 0;
// int SumMinus = 0;

// for(int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }


// Console.WriteLine();
// for(int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]*-1} ");
// }


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] random(int start, int  end, int LengthArr)
// {
//     int[] arr = new int[LengthArr];
//     for (int i = 0; i < LengthArr; i++)
//     {
//         arr[i] = new Random().Next(start, end + 1);
//     }
//     return arr;
// }

// int[] arr = random(-2, 2, 10);

// for(int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }

// void check(int x, int[] arr)
// {
//     string res = "";

//     for(int i = 0; i < arr.Length; i++)
//     {
//         if (x == arr[i]){res = "Число есть в массиве"; break;}
        
//         else {res = "Числа нет в массиве"; break;}
//     }
//     Console.WriteLine(res);
// }

// check(2, arr);


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите число А ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число В ");
// int b = Convert.ToInt32(Console.ReadLine());

// int x = a;

// for (int i = 1; i < b; i++)
// {
//     x = x * a;
// }
// Console.WriteLine($"A в степени B равно: {x}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Clear();
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (n > 0)
// {
//     int b = n % 10;
//     n = n / 10;
//     sum = sum + b;
// }
// Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int [] array = new int[8];
// int i  = 0;
// while (i < array.Length)
// {
//     array[i] = new Random().Next(0,10);
//     i++;
// }
// Console.WriteLine(String.Join(" ",array));


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int size = new Random().Next(2,20);
// int[] numbers = new int[size];
// ArrayRandom(numbers);
// PrintArray(numbers);
// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
// if (numbers[i] % 2 == 0)
// count++;

// void ArrayRandom(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
    
// }
// Console.WriteLine();
// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int size = new Random().Next(2,20);
// int[] numbers = new int[size];
// RandomNumbers(numbers);
// PrintArray(numbers);
// int sum = 0;

// for (int i = 0; i < numbers.Length; i+=2)
//     sum = sum + numbers[i];

// void RandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }
// Console.WriteLine("Вот наш массив: ");
// Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// int size = new Random().Next(2,20);
// int [] numbers = new int[size];
// RandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int min = Int32.MaxValue;
// int max = Int32.MinValue;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//         {
//             max = numbers[i];
//         }
//     if (numbers[i] < min)
//         {
//             min = numbers[i];
//         }
// }

// void RandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToInt32(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// Задача 39: Напишите программу, которая перернет одномерный массив 

// [1 2 3 4 5] -> [5 4 3 2 1]



// int [] x = {1, 2, 3, 4, 5};

// for(int i = 0; i < x.Length; i++)
// {
//     x[i] = x[x.Length - 1 - i];
//     Console.WriteLine($"{x[i]} ");
// }


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с такой длинной 


// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);

// if (a < (b + c) & b < (c + a) & c < (a + b)) Console.WriteLine("Это треугольник");
// else Console.WriteLine("Это НЕ треугольник");



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное 


// System.Console.Write($"Введите число ");
// int dec = Convert.ToInt32(Console.ReadLine());

// string binary = string.Empty;

// while (dec != 0)
// {
//     binary = Convert.ToString(dec % 2) + binary;
//     dec = dec / 2;
// }

// System.Console.WriteLine($"{binary}");

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначи. Первые два числа Фибоначи 0 и 1.

// string Array(int[] arr)
// {
//     string result = "[";

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//         {
//             result = result + $"{arr[i]}, ";
//         }
//         else 
//         {
//             result = result + $"{arr[i]}";
//         }
//     }
//     result = result + "]";
//     return result;
// }

// System.Console.Write($"Введите число ");
// int dec = Convert.ToInt32(Console.ReadLine());
// int [] f = new int[dec];

//     f[0] = 0;
//     f[1] = 1;

// for (int i = 2; i < dec; i++)
// {
//     f[i] = f[i - 1] + f[i - 2];
// }

// System.Console.WriteLine($"{dec} -> {Array(f)}");

// Задача 45: Напишите программу котрая будет создавать копию заданного массива с помощью поэлементраного копирования.

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");


// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }


// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// Console.WriteLine("введите количество строк");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// ArrayRandom(numbers);
// PrintArray(numbers);

// void ArrayRandom(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Console.WriteLine("line numbers ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("column number");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [5,5];
// ArrayNumbers(numbers);


// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("no element");
// }
// else
// {
//     Console.WriteLine($"element is equal to {n} and {m} = {numbers[n-1,m-1]}");
// }


// void ArrayNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(0, 100);
//             }   
//         }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }
// PrintArray(numbers);


// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int [,] numbers = new int [10,10];
// ArrayNumbers(numbers);

// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         sum = (sum + numbers[i, j]);
//     }
//     sum = sum / numbers.GetLength(0);
//     Console.Write(sum + "; ");
// }
// Console.WriteLine();

// PrintArray(numbers);


// void ArrayNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(0, 10);
//             }   
//         }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int [,] numbers = new int [3,3];
// ArrayNumbers(numbers);
// PrintArray(numbers);
// Console.WriteLine();
// Ordering(numbers);

// void Ordering(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// void ArrayNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(0, 10);
//             }   
//         }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }


// PrintArray(numbers);
// Ordering(numbers);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] numbers = new int [3,4];
ArrayNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
NumberRowMinSumElements(numbers);

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        minRow += numbers[0, i];
    }
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++) sumRow += numbers[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка с наименьшей суммой");
    Console.WriteLine();
}

void ArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

