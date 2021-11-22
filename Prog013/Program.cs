

int numberA = new Random().Next(1, 10); 
int numberB = new Random().Next(1, 10);

if (numberA < numberB)

{
    Console.Write(numberA);
    Console.WriteLine(" - min");
    Console.Write(numberB);
    Console.WriteLine(" - max");
}

else if (numberA == numberB)
    {
      Console.WriteLine(numberA);
      Console.WriteLine(numberB);  
      Console.WriteLine("Значения равны");
    }   


else 
{
Console.Write(numberA);
Console.WriteLine(" - max");
Console.Write(numberB);
Console.WriteLine(" - min");
}


