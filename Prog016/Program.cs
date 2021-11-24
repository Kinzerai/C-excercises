// Intro_Array первая задача с массивами с лекции 2

int[] array = { 1, 12, 13, 43, 2, 76, 45, 34, 21, 34, 7, 9};

int n = array.Length;
int find = 34;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
