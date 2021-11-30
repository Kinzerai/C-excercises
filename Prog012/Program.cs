
//По двум заданным числам проверять является ли первое квадратом второго

int numberA = new Random().Next(1, 17);
Console.WriteLine(numberA);
int result1 = numberA;

int numberB = new Random().Next(1, 5);
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