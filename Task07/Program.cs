// Показать числа от -N до N

Console.Clear();
Console.WriteLine("Введите любое число: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
int NumberMinusN = - NumberN;
int count = -NumberN;
int result = - NumberN-1;

while (count <= NumberN)
{
    result = result + 1; 
Console.WriteLine(result);
count++;
}



