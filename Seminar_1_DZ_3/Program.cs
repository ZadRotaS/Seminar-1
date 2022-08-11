Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
string res = "A";
if (N % 2 == 0)
{
    res = "четным";
}
else
{
    res = "нечетным";
}
Console.WriteLine("Число: " + N.ToString() + " является " + res.ToString() );