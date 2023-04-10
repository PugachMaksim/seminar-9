/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int M;
int N;
Console.WriteLine("Введите число M: ");
int.TryParse(Console.ReadLine(), out M);
Console.WriteLine("Введите число N: ");
int.TryParse(Console.ReadLine(), out N);

if (M >= 0 && N >= 0)

{
    int Akkerman (int m, int n)
    {
        if (m == 0)
                return n + 1;
        else if (n == 0)
                return Akkerman(m-1, 1);
        else 
                return Akkerman (m-1, Akkerman (m, n-1));
    }

Console.WriteLine($"A({M}, {N}) = {Akkerman (M, N)}");
}
else

    Console.WriteLine("Неверный ввод");