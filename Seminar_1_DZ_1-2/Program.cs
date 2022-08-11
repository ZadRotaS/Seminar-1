Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = new int[m];
int i = 0;
while (true)
{
    if (i < m)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i += 1;
    }
    else
    {
        break;
    }
}
i = 0;
int max = 0;
while (i < m)
{
    if (array[i] > max)
    {
        max = array[i];
        i += 1;
    }
    else
    {
        i += 1;
    }
}
i = 0;
int min = array[i];
while (i < m)
{
    if (array [i] < min)
    {
        min = array[i];
        i += 1;
    }
    else
    {
        i += 1;
    }
}
Console.WriteLine("максимальное число: " + max.ToString());
Console.WriteLine("минимальное число: " + min.ToString());
