﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32 (Console.ReadLine());

bool TriangleTrue(int number1, int number2, int number3)
{
bool result = default;
if (number1 < (number2 + number3) && number2 < (number1 + number3) && number3 < (number1 + number2)) return true;
return result;
}

bool triangleTrue = TriangleTrue(num1, num2, num3);
Console.WriteLine($"{triangleTrue}");