// // // // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // // a = 5; b = 7 -> max = 7
// // // a = 2 b = 10 -> max = 10
// // // a = -9 b = -3 -> max = -3



// // Console.Write("Введите первое число ");

// // int num1 = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Введите второе число ");

// // int num2 = Convert.ToInt32(Console.ReadLine());

// // if (num1 > num2)
// // {
// //     Console.WriteLine(num1 + " Это большее число");
// //     Console.WriteLine(num2 + " Это меньшее число");
// // }
// // else
// // {
// //     Console.WriteLine(num2 + " Это большее число");
// //     Console.WriteLine(num1 + " Это меньшее число");
// // }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");

int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2)
{
    if (num1 >= num3)
    Console.WriteLine(num1 + " Это большее число");
}
if (num2 > num3)
{
    if (num2 >= num1)
    Console.WriteLine(num2 + " Это большее число");
}
if (num3 >= num2)
{
    if (num3 >= num1)
    Console.WriteLine(num3 + " Это большее число");
}
    