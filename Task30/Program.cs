// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.Write("Введите четное число: ");
int NumA = Convert.ToInt32(Console.ReadLine());

if (NumA % 2 != 0) Console.WriteLine("Вы ввели нечетное число!");
else Console.WriteLine($"Куб числа {NumA} равен {Math.Pow(NumA,3)}");



