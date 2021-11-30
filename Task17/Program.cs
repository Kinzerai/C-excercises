// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();
int NumA = new Random().Next(1,10);
int NumB = new Random().Next(1,10);
//int NumA = 12;
//int NumB = 144;
Console.WriteLine(NumA);
Console.WriteLine(NumB);
int result1 = NumB*NumB;
int result2 = NumA*NumA;

if (NumA == NumB*NumB) Console.WriteLine(result1);
if (NumB == result2) Console.WriteLine(result2);
if ((NumA != NumB*NumB) && (NumB != NumA*NumA)) Console.WriteLine("Не является квадратом");


