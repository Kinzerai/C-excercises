//Написать программу, которая из имеющегося массива целых чисел формирует 
//массив из четных чисел.
//Первоначальный массив можно ввести с клавиатуры, 
//либо сгенерировать случайным образом. 

Console.Clear();

void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
}

}

void PrintArray(int[] array)

{
    Console.Write("Массив {");
for (int j = 0; j < array.Length; j++)
{
    Console.Write(" " + array[j] + " ");
}
Console.Write("}");
//Console.WriteLine();
}

int[] FillNewArray(int[] array)

{
int NewArrayLength = 0;

for (int l = 0; l < array.Length; l++)
{
    if (array[l] % 2 == 0)
    {
        NewArrayLength = NewArrayLength + 1;
    }
}


int[] NewArray = new int[NewArrayLength];

for (int k = 0, m = 0; k < array.Length; k++)
{
    if (array[k] % 2 == 0)
    {
        NewArray[m] = array[k];
       m++;
    }
}
return NewArray;
}


int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.Write(" -> Новый ");
FillNewArray(array);
PrintArray(FillNewArray(array));
Console.WriteLine();






