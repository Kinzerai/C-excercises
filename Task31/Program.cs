//31. Задать массив из 8 элементов и вывести их на экран

Console.Clear();

int[] array = new int[8];
//Random rnd = new Random();

Console.Write("{");
for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(0,100);
    Console.Write(" " + array[i]+ " ");
}
Console.WriteLine("}");



