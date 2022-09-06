/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 */

Console.WriteLine("Введите число (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman(int m, int n)
{
	if (m == 0) return (n + 1);
	if (n == 0) return (functionAkkerman(m - 1, 1));
	else return (functionAkkerman(m - 1, functionAkkerman(m, n - 1)));
}
Console.WriteLine($"Расчета функции Аккермана для m = {m} и n = {n} - {functionAkkerman(m,n)}");
