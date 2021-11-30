// Дано число. Проверить кратно ли оно 7 и 23
Console.Clear();
int NumA = 49;
int NumB = 7;
int NumC = 23;

if ((NumA % NumB == 0) && (NumA % NumC ==0)) Console.WriteLine("Число"+" " + NumA + " "+ "кратно 7 и 23");
else Console.WriteLine("Число" + " " + NumA + " " + "не делится без остатка на 7 и 23");
