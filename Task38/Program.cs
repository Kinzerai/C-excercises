// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

//Console.Clear();

int[] array = new int[8];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("}");

int sum = 0;
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 0)
    {
        sum = sum + array[j];
    }
}
 Console.WriteLine($"Сумма чисел (нечетной позиции) массива = {sum}");