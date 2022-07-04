Console.Write("Введите число.");
int i = Convert.ToInt32(Console.ReadLine()); 
if (i < 8)
{
    if (i > 0) 
      {
          if (i == 7)
          {
           Console.Write("Выходной");
          }
         else
          {
            if (i == 6)
            {
            Console.Write("Выходной");
            }
            else
            {
            Console.Write("Будний");
            }
            }
        }
    else 
    {
    Console.Write("не соответствует дням недели.");
    }
}     
else 
{
    Console.Write("не соответствует дням недели.");
}
