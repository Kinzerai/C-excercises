//По заданному номеру дня недели вывести его название

Console.Clear();
string[] Weekdays = {" ","Mon", "Tue", "Wed", "Thr", "Fr", "Sat", "Sun"};

Console.Write("Enter number: ");

int index = int.Parse(Console.ReadLine());

Console.WriteLine(Weekdays[index]);  




