// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.WriteLine("Введите номер четверти от 1 до 4: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 1 || x >= 5) Console.WriteLine("Значения введены неправильно!");
if (x == 1) Console.WriteLine($"В четверти {x} находятся координаты x > 0 и y > 0");
if (x == 2) Console.WriteLine($"В четверти {x} находятся координаты x < 0 и y > 0");
if (x == 3) Console.WriteLine($"В четверти {x} находятся координаты x < 0 и y < 0");
if (x == 4) Console.WriteLine($"В четверти {x} находятся координаты x > 0 и y < 0");

