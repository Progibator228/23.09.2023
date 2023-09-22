string Integers ( int N )
{
    if (N == 0)
        return " " ;     
    else
        return   $" {N}" + Integers(N-1) ;
}
System.Console.WriteLine("Введите от какого числа по 1 вывести все натуральные числа ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Integers(num));