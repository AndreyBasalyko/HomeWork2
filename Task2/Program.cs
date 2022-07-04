Console.Write("Введите число.");
string i = Console.ReadLine();
string a = i.Substring(2,1);
if (i.Length < 3)
{
   Console.Write("Третьей цифры нет.");
}
else
{
    Console.Write(a);
}