// 47. Написать программу копирования массива

int[] ArrayOne = new int[10];


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($" {array[i]} ");

    }
    Console.WriteLine();
}

void PrintArray(int[] array)


{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");

    }
    Console.WriteLine();
}

void FillNewArray(int[] array, int[] newarray)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - newarray [i];
    }
}

int[] ArrayTwo = new int[ArrayOne.Length];

FillArray(ArrayOne);
FillNewArray(ArrayTwo,ArrayOne);
PrintArray(ArrayTwo);



// ArrayOne [3] = 25; // чтобы проверить, что второй массив не меняется 
// PrintArray(ArrayOne);
// PrintArray(ArrayTwo);









// Без методов:
// for (int i = 0; i < ArrayOne.Length; i++)
// {
//     ArrayOne[i] = new Random().Next(1, 100);
//     Console.Write($" {ArrayOne[i]} ");

// }
//  Console.WriteLine();


// int [] ArrayTwo = new int[ArrayOne.Length];

// for (int j = 0; j<ArrayTwo.Length; j++)
// {
//     ArrayTwo[j] = - ArrayOne[j];
//     Console.Write($" {ArrayTwo[j]} ");

// }
//  Console.WriteLine();





