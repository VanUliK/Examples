Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "vano")
{
    Console.WriteLine("Приветствуем тебя, VanUliK");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}