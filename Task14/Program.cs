// Найти третью цифру числа или сообщить, что её нет
Console.Clear();

void Find3Num(int NumberA)

{
    string NumberB = NumberA.ToString();

    if (NumberB.Length > 2) Console.WriteLine($"Третья цифра числа: {NumberB[2]}");
    else Console.WriteLine("Нет третьей цифры");
}

Console.Write("Введите любое число: ");

Find3Num(Convert.ToInt32(Console.ReadLine()));

//
//Console.Clear();

//void Find3Num(string NumberA)

//{if (NumberA.Length > 2) Console.WriteLine($"Третья цифра числа: {NumberA[2]}");
//else Console.WriteLine("Нет третьей цифры");}

//Console.Write("Введите любое число: ");
//string NumberA = Console.ReadLine();

Find3Num(Console.ReadLine());






//if(NumberA[2]== 0) Console.WriteLine("В числе меньше трех цифр");

//string.Empty - пока не знаю как вывести что нет цифры
