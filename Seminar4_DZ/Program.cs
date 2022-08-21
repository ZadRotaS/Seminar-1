int x = 0;
void Select(string[] words)
{
    for(int i = 0; i < words.Length -1; i++)
    {
        Console.Write(i+1 + " - " + words[i] + " ");
    }
    Console.Write(words.Length + " - " + words[words.Length-1] + ".");
    Console.WriteLine("");
}
void SelectTesk()
{
    string[] namesTesk = {"Число N возвести в степень X","Сумма цифр числа N","Создать массив из N элементов и вывести их в консоль",};
    Console.WriteLine("Выбери задачу: ");
    Select(namesTesk);
    x = Convert.ToInt32(Console.ReadLine());
    
    if (x > namesTesk.Length)
    {
        Console.WriteLine("Вы выбрали задачу которой нету запустите заного и выберите задачу из списка.");
    }
    else
    {
        string TeskHero = namesTesk[x -1];
        Console.WriteLine("Вы выбрали задачу: " + TeskHero); 
    }
}
void PrintArray(int[] mast)
{
    for (int i = 0; i < mast.Length; i++)
    {
        Console.Write(mast[i] + " ");
    }
}
void FillArray(int[] mast)
{
    for (int i = 0; i < mast.Length; i++)
    {
        mast[i] = new Random().Next(0,99);
    }
}

SelectTesk();

if (x == 1)
{
    Console.Write("Введите число: "); int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень: "); int X = Convert.ToInt32(Console.ReadLine());
    int N1 = 1;
    for(int i = 0; i < X; i++)
    {
        N1 = N1 * N;
        Console.WriteLine(N1);
    }
    Console.Write("Ответ: " + N1);
}
if (x == 2)
{
    int i, x1 = 0, n = 0;
    Console.Write("Введите число: ");
    int N = Convert.ToInt32((Console.ReadLine()));
    for (i = N; i > 0; i = (i / 10))
        {
            x1 = i % 10;
            n = n + x1;

        }
    Console.WriteLine("Ответ: " + n);
}
if (x == 3)
{
    Console.Write("Введите количество элементов массива: "); int N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];
    FillArray(array);
    PrintArray(array);
}