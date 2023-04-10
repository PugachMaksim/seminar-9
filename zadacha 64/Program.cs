/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int N;
Console.WriteLine("Введите число N: ");
int.TryParse(Console.ReadLine(), out N);

Console.Write($"N = {N} -> ");
int rekurs(int n)
{
    if (n == 1) 
    {   
        Console.Write($"{n}"); 
        return (n);
    }
    else
    {
        Console.Write($"{n}, "); 
        return rekurs(n-1);
    }
}
rekurs(N);