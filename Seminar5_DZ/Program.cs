int x = 0;
void Select(string[] words)
{
    for(int i = 0; i < words.Length; i++)
    {
        Console.WriteLine(i+1 + " - " + words[i] + ".");
    }
    
}
void SelectTesk()
{
    string[] namesTesk = {"Создать массив с случайными числами и вывести количество четных чисел","Сумма элементов стоящих на нечетных позициях","Создать массив чисел и найти мин. маск. и разницу между ними",};
    Console.WriteLine("Задачи:");
    Select(namesTesk);
    Console.WriteLine("Выбери задачу: ");
    x = Convert.ToInt32(Console.ReadLine());
    
    if (x > namesTesk.Length)
    {
        Console.WriteLine("Вы выбрали задачу которой нету запустите заного и выберите задачу из списка.");
    }
    else
    {
        string TeskHero = namesTesk[x -1];
        Console.WriteLine("Вы выбрали задачу: " + TeskHero + "."); 
    }
}
void PrintArray(int[] mast)
{
    for (int i = 0; i < mast.Length; i++)
    {
        Console.Write(mast[i] + " ");
    }
    Console.WriteLine();
}
void FillArray(int[] mast, int min,int max)
{
    for (int i = 0; i < mast.Length; i++)
    {
        mast[i] = new Random().Next(min,max);
    }
}

SelectTesk();

if (x == 1)
{
    Console.Write("Введите количество рандомных чисел: "); int N = Convert.ToInt32((Console.ReadLine()));
    int[] array = new int [N];
    FillArray(array, 100, 999);
    PrintArray(array);
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            n++;
        }
    }
    
    Console.WriteLine("Количество четных чисел в масиве: " + n);

}
if (x == 2)
{
    Console.Write("Введите количество рандомных чисел: "); int N = Convert.ToInt32((Console.ReadLine()));
    int[] array = new int[N];
    FillArray(array, -99, 99);
    PrintArray(array);
    int n = 0, i = 0;
    while (i < N)
    {
        n = n + array[i];
        i += 2;
    }
    Console.WriteLine("Сумма чисел на не четных позициях ровна: " + n);
}
if (x == 3)
{
    Console.Write("Введите количество элементов массива: "); int N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];
    FillArray(array, 0, 100);
    PrintArray(array);
    int Min = array[0], Max = array[0]; 
    for(int i = 0; i < array.Length; i++)
    {
        if(Min > array[i]){Min = array[i];}
        if(Max < array[i]){Max = array[i];}
    }
    int n = Max - Min;
    Console.WriteLine("мин "+ Min);
    Console.WriteLine("маск "+ Max);
    Console.WriteLine("Разница: "+ n);
}


