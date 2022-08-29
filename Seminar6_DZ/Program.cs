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
    string[] namesTesk = {"Задача 1. Одномерный массив из 123 чисел","Задача 2. Произведение пар чисел в одномерном массиве"};
    Console.WriteLine("Задачи:");
    Select(namesTesk);
    Console.Write("Выбери задачу: ");
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
void PrintArray(int[] mast) // Вывести моссив в консоль
{
    for (int i = 0; i < mast.Length; i++)
    {
        Console.Write(mast[i] + " ");
    }
    Console.WriteLine();
}
void FillArray(int[] mast, int min,int max) // Заполнить моссив случайными числами от Х до Y
{
    for (int i = 0; i < mast.Length; i++)
    {
        mast[i] = new Random().Next(min,max);
    }
}
string Text = string.Empty;

while(Text != "end")
{
    Console.Clear();
    SelectTesk();

    if (x == 1)
{
    int[] array = new int [123];
    FillArray(array,0,123);
    PrintArray(array);
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 9) 
            if(array[i] < 100) 
                {n++;}
    }
    Console.WriteLine("Числел больше 10 и меньше 100 в масиве: " + n);
    Console.Write("Для завершения введите (end) для продолжение любой другой символ: ");
    Text = Convert.ToString(Console.ReadLine());
        
    
}
    if (x == 2)
{
    Console.Write("Введите количество числе в массиве: "); int N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];
    FillArray(array,1,9);
    PrintArray(array);
    Console.Write(" -> ");
    int n = 0 , j = array.Length - 1;
    for(int i = 0; i <= (N - 1) / 2 ; i++,j--)
    {
        if(i == j) {Console.Write(" " + array[i]);}
        else
        {
            n = array[i] * array[j];
            Console.Write(" " + n);
        }    
    }
    Console.WriteLine();
    Console.Write("Для завершения введите (end) для продолжение любой другой символ: ");
    Text = Convert.ToString(Console.ReadLine()); 
}
}
