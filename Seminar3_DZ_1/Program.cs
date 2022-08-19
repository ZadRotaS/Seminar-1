int i, x = 0, n = 0;
Console.Write("Введите число: ");
int N = Convert.ToInt32((Console.ReadLine()));
for (i = N; i > 0; i = (i / 10))
    {
            x = i % 10;
            n = n * 10 + x;

    }
Console.WriteLine(n);
if(N==n)
{
    Console.WriteLine("число: " + N + " является палиндромом");
}
else 
{
    Console.WriteLine("число: " + N + " неявляется палиндромом");
}

