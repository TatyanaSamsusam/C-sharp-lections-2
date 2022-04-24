Console.WriteLine("write your name");
string username = Console.ReadLine();

if (username.ToLower() == "masha") // .ToLower() переводит все символы в нижний регистр, как в примере
{
    Console.WriteLine("wow it's MASHA!!!");
}
else
{
    Console.Write("hi ");
    Console.WriteLine(username);
}
