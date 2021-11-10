//Приветствие разных пользователей

Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "лика")
{
    Console.WriteLine("Ура, это же сама Лика!!!");
}

if (username.ToLower() == "илья")
{
    Console.WriteLine("Неужели это сам Илья!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!");


}
