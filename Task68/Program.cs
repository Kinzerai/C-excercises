// Показать натуральные числа от M до N, N и M заданы

void NNumbers(int N, int M)
{
    if (N >M) {Console.WriteLine(N); NNumbers(N-1);}
  
}
NNumbers(10);


