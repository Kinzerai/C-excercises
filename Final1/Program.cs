//Написать программу, которая из имеющегося массива целых чисел формирует 
//массив из четных чисел.
//Первоначальный массив можно ввести с клавиатуры, 
//либо сгенерировать случайным образом. 


Console.Clear();

int[] array = new int[5];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(" " + array[i] + " ");
}
Console.Write("}");

Console.Write("\nЭлементы для нового массива четных чисел");

int NewArrayLength = 0;

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
    {
        NewArrayLength = NewArrayLength + 1;
        Console.Write(" " + array[j] + " ");
    }

}
Console.WriteLine($"\nКол-во четных элементов {NewArrayLength}");


int[] NewArray = new int[NewArrayLength];

Console.Write("Массив {");
for (int k = 0, m = 0; k < array.Length; k++)
{
    if (array[k] % 2 == 0)
    {
        NewArray[m] = array[k];
       
        Console.Write($" {NewArray[m]} ");
        m++;
    }
}
Console.Write("}");
Console.WriteLine();





