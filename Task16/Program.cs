// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


Console.Clear();
string[] Weekdays = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
Console.Write("Введите номер дня недели: ");
int index = Convert.ToInt32(Console.ReadLine());

if (index > 7) Console.WriteLine("Вы ввели неверное значение. Введите от 1 до 7.");
if (index < 6) Console.WriteLine (Weekdays[index-1] + " - будний день");
else Console.WriteLine(Weekdays[index-1] + " - выходной день");

