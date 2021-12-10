// 39. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

//1 ВАРИАНТ:

// Console.Clear();

// int[] array = new int[8];

// Console.Write("Массив");
// for (int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(2,20);
//     Console.Write(" " + array[i]+ " ");
// }

// Console.WriteLine($"\n{array[0]}*{array[7]} = {array[0]*array[7]}");
// Console.WriteLine($"{array[1]}*{array[6]} = {array[1]*array[6]}");
// Console.WriteLine($"{array[2]}*{array[5]} = {array[2]*array[5]}");
// Console.WriteLine($"{array[3]}*{array[4]} = {array[3]*array[4]}");

//2 ВАРИАНТ

Console.Clear();

int[] array = new int[8];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(2, 20);
    Console.Write(" "+ array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < (array.Length/2); j++)
{
    int first = array[j];
    int last = array[array.Length - 1 - j];
    int sum = first * last;
    Console.WriteLine($"{first}*{last} = {sum}");
}


