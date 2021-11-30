// Найти максимальное из трех чисел

int NumA = 2;
int NumB = 6;
int NumC = 3;

int max = NumA;

if (NumB > max) 
{
    max = NumB;
}

if (NumC > max) 
{
    max = NumC;
}

Console.WriteLine(max);

