// Показать последнюю цифру трёхзначного числа

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine());
int B = (A%100);
int C = (B%10);

Console.WriteLine(C);