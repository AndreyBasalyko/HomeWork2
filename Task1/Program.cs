Console.Write("Введите трехзначное число.");
string i = Console.ReadLine();
string a = i.Substring(1,1);
if (i.Length > 3)
{
    Console.Write("Слишком большое число.");
}
if (i.Length < 3)
{
   Console.Write("Слишком маленькое число.");
}
if (i.Length == 3)
{
    Console.Write(a);
}