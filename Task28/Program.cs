//28.  Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите число: ");
string Num = Console.ReadLine();
int length = Num.Length;
int NumB = 0;
int sum = 0;

for (int index = 0; index < length; index++)
{
    NumB = Convert.ToInt32(Num[index] - '0');
    Console.WriteLine($"Цифра: {NumB}");
    sum = sum + NumB;
}
Console.WriteLine($"Сумма всех цифр числа {Num} равна {sum}.");