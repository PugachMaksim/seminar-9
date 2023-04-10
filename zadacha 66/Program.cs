/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int N;
int M;
Console.WriteLine("Введите число M: ");
int.TryParse(Console.ReadLine(), out M);
Console.WriteLine("Введите число N: ");
int.TryParse(Console.ReadLine(), out N);


int rekurs(int m, int n)
{
    if (m == n) 
    {   
        return (m);
    }
    else
    {
        return m + rekurs(m+1, n);
    }
}
Console.WriteLine($"{rekurs(M, N)}");