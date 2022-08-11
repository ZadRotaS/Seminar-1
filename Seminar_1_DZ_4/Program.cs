Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int I = N / 2;
int [] array = new int [I + 1];
I = 0;
while (i < N)
{
    if (i % 2 == 0)
    {
        array[I] = i;
        I += 1;
        i += 1;
    }
    else
    {
        i += 1;
    }
}
I = 0;
Console.Write("Все четные числа, чила до " + N.ToString() + " это: " );
while (I < (N / 2))
{
        Console.Write(array[I] + ",");
        I += 1;
}
