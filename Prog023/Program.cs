
// Показать четные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int numberB = 1;
int result = 0;
int count = 1;

while (count < numberN)
{
    result = numberB + count;
    if (result % 2 == 0)
    {
        Console.WriteLine(result);
    }
    count++; 
}




