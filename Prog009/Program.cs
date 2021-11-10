//задача с гирями: найти самую тяжелую из 5

int a = 4;
int b = 10;
int c = 16;
int d = 2;
int e = 25;
 
 int max = a;

 if (a > max) max = a;
 if (b > max) max = b;
 if (c > max) max = c;
 if (d > max) max = d;
 if (e > max) max = e;

 Console.Write("max = ");
 Console.WriteLine(max);
