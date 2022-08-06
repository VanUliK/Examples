Console.WriteLine("Введите имя пользователя: ");
String username = Console.ReadLine();

if (username.ToLower() == "vano")
{
    Console.WriteLine("Приветствуем тебя, VanUliK");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

