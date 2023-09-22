int DZ66(int M, int N)
{
    if (M == N)
        return M;
    else
        return M + DZ66(M + 1, N);
}
System.Console.WriteLine("Считаем от  ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Считаем до");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна = {DZ66(M, N)}");