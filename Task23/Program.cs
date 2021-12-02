// Показать таблицу квадратов чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
double NumA = Convert.ToInt32(Console.ReadLine());
double count = 0;
double result = 0;
double sqr = 0;

while (count < NumA)
{
    result = result + 1;
    sqr = Math.Pow(result,2);

    Console.WriteLine($"Квадрат числа {result} равен: {sqr} ");

    count++;
}