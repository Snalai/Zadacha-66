// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Funk(int M, int N)
{
    if (N == M)
    {
        return M;
    }
    else
        return M + Funk(M + 1, N);
}
Console.WriteLine(Funk(4, 8));
