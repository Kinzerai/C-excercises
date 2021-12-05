// Возведите число А в натуральную степень B используя цикл


Console.Clear();
int numA = new Random().Next(-10,10);
int numB = new Random().Next(1,3);
Console.WriteLine(numA);
Console.WriteLine(numB);
int result = 1;
for (int count = 0; count<numB; count++)
{
result = result * numA;
}
Console.WriteLine(result);