// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
Console.Clear();

int[] array = new int[7];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("}");

int count1 =0;
int count2 =0;

for (int j = 0; j<array.Length; j++)
{
    if (array[j] % 2 ==0) 
    {
        count1 = count1 + 1;
    }
    if (array[j] % 2 !=0)
    {
        count2 = count2+1;
    }
}
Console.WriteLine($"В массиве {count1} четных и {count2} нечетных чисел");


