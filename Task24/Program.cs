//Найти кубы чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число: ");
double NumA = Convert.ToInt32(Console.ReadLine());
double count = 0;
double result = 0;
double cubic = 0;

while (count < NumA)
{
    result = result + 1;
    cubic = Math.Pow(result, 3);
    Console.WriteLine($"Куб числа {result} равен {cubic} ");
    count++;
}