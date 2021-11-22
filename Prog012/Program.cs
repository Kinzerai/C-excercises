
int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int result1 = numberA*numberA;

int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result2 = numberB*numberB;

if (result1 == result2) 

{
Console.WriteLine ("Верно");
}
else
{
    Console.WriteLine("Не квадрат!");
}