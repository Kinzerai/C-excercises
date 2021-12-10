// 40. В Указанном массиве вещественных чисел 
//найдите разницу между максимальным и минимальным элементом

Console.Clear();

int[] array = new int[10];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(2, 40);
    Console.Write(" "+ array[i] + " ");
}
Console.WriteLine();

int min = array[0];
int max = 0;

for (int j = 0; j < (array.Length); j++)
{
    if (array[j]>max) max = array[j];
    if (array[j]< min) min = array [j];
}

Console.WriteLine($"Минимальный элемент массива - {min}");
Console.WriteLine($"Максимальное элемент массива - {max}");
Console.WriteLine($"Разница между макс и мин элементами - {max - min}");
