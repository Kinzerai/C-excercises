// Найти сумму чисел от 1 до А

Console.Clear();
Console.WriteLine("Введите число: ");
int NumA = Convert.ToInt32(Console.ReadLine());
int result = 0;
int count = 0;
int sum = 0;

while (count < NumA)
{
    result = result + 1;
    sum = sum + result;
    count++;
}

Console.WriteLine(sum);
