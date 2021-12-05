// 21. Программа проверяет пятизначное число на палиндромом.

Console.Clear();
Console.WriteLine("Введите числовой палиндром из 5 чисел: ");
string Num = Console.ReadLine();
int length = Num.Length;

if (length > 5 || length < 5) Console.WriteLine("Неверно введено число!");
if (Num[0] == Num[4] && Num[1] == Num[3]) Console.WriteLine($"Число {Num} - палиндром");
else Console.WriteLine($"Число {Num} не является палиндромом");



