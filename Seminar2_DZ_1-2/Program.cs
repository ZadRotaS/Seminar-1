Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x > 9)
{
    int a = int.Parse(Convert.ToString(x)[1].ToString());
    Console.WriteLine("Вторая цифра этого числа: " + a);
}
else
{
    Console.WriteLine("Второй цифры нет");
}
if(x > 99)
{
    int b = int.Parse(Convert.ToString(x)[2].ToString());
    Console.WriteLine("Третья цифра этого числа: " + b);
}
else 
{
    Console.WriteLine("Третей цифры нет");
}
