// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();
int[] array = new int[6];
Console.WriteLine("Введите 6 элементов массива: ");

for (int i =0; i<6; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for (int j=0; j<6; j++)
{
   if (array[j]>0) count = count +1; 
}

Console.WriteLine($"Больше 0 введено {count} ");



