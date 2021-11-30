//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear();
int NumberA = new Random().Next(10,99);
Console.WriteLine(NumberA);
int Num1 = NumberA %10;
int Num2 = NumberA/10;

if (Num1 > Num2) Console.WriteLine("Наибольшая цифра = " + Num1);
else Console.WriteLine("Наибольшая цифра = " +Num2);