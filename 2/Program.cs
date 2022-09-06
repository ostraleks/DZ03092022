﻿/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
int summa(int M, int N)
{
	if (M == N) return M;
	return (M + summa((M + 1), N));
}
Console.WriteLine($"Сумма чисел от {M} до {N}: {summa(M, N)}");
