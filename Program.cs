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

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i < x+1)
{
    Console.Write($"{Math.Pow(i, 3)} "); i++;
}
