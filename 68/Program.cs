int A (int  N, int M)
{
  if (N == 0)
    return M + 1;
  else
    if ((N != 0) && (M == 0))
      return A(N - 1, 1);
    else
      return A(N - 1, A(N, M - 1));
}
System.Console.WriteLine("Первое число ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Второе число");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(A(n,m));


