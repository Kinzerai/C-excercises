// 29. Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число: ");
double NumA = Convert.ToInt32(Console.ReadLine());
double count = 0;
double result = 0;
double multi = 1;

while (count < NumA)
{
    result = result + 1;
    multi = multi*result;
    count++;

}

Console.WriteLine($"Произведение чисел от 1 до {NumA} равно {multi} ");